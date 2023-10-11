using Microsoft.Xrm.Sdk;
using Odx.Demo.Model;
using System;
using System.Linq;

namespace Odx.Demo.PipelineSimulator.Plugins
{
    public class OpportunityNotificationsPlugin : PluginBase
    {
        public OpportunityNotificationsPlugin(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(OpportunityNotificationsPlugin))
        {
        }

        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            var context = localPluginContext.PluginExecutionContext;
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                var entity = (Entity)context.InputParameters["Target"];

                if (entity != null && entity.LogicalName == Opportunity.EntityLogicalName)
                {
                    var service = localPluginContext.InitiatingUserService;
                    var opportunity = entity.ToEntity<Opportunity>();
                    if (opportunity.OwnerId != null
                        && opportunity.OpportunityRatingCode == opportunity_opportunityratingcode.Hot)
                    {
                        using (var ctx = new DataverseContext(service))
                        {
                            var owner = ctx.CreateQuery<SystemUser>()
                                .Where(x => x.Id == opportunity.OwnerId.Id)
                                .FirstOrDefault();

                            if (owner?.ParentSystemUserId != null)
                            {
                                var from = new ActivityParty()
                                {
                                    PartyId = new EntityReference(SystemUser.EntityLogicalName, localPluginContext.PluginExecutionContext.InitiatingUserId)
                                };
                                var to = new ActivityParty() { PartyId = owner.ParentSystemUserId };

                                //For the purpose of this demo - let's just create e-mail record and not really send it
                                service.Create(new Email()
                                {
                                    Subject = "Hey. There is a interesting opportunity worthy taking a look :)",
                                    From = new ActivityParty[] { from },
                                    To = new ActivityParty[] { to },
                                    RegardingObjectId = opportunity.ToEntityReference()
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}
