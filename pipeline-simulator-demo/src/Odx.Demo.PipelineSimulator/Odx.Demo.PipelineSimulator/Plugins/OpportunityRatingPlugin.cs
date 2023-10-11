using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Odx.Demo.Model;
using System;
using System.Linq;

namespace Odx.Demo.PipelineSimulator.Plugins
{
    public class OpportunityRatingPlugin : PluginBase
    {
        public OpportunityRatingPlugin(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(OpportunityRatingPlugin))
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
                    var opportunity = entity.ToEntity<Opportunity>(); 
                    if(opportunity.CustomerId != null 
                        && opportunity.CustomerId.LogicalName == Account.EntityLogicalName)
                    {
                        using (var ctx = new DataverseContext(localPluginContext.InitiatingUserService))
                        {
                            var account = ctx.CreateQuery<Account>()
                                .Where(x => x.Id == opportunity.CustomerId.Id)
                                .FirstOrDefault();

                            //For the purpose of this demo - let's assume € is base currency in our environment
                            if (account?.Revenue_Base?.Value > 10000000) 
                            {
                                opportunity.OpportunityRatingCode = opportunity_opportunityratingcode.Hot; 
                            }
                        }
                    }
                }
            }
        }
    }
}
