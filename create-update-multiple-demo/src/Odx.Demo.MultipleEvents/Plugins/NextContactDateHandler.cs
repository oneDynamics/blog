using Microsoft.Xrm.Sdk;
using Odx.Demo.MultipleEvents.Common.Model;
using System;

namespace Odx.Demo.MultipleEvents.Plugins
{
    public class NextContactDateHandler : PluginBase
    {
        public NextContactDateHandler(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(NextContactDateHandler))
        {
        }

        // Entry point for custom business logic execution
        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                var entity = (Entity)context.InputParameters["Target"];

                // Check for entity name on which this plugin would be registered
                if (entity.LogicalName == Contact.EntityLogicalName)
                {
                    var contact = entity.ToEntity<Contact>();
                    if (contact.odx_nextcontactdate.HasValue)
                    {
                        localPluginContext.InitiatingUserService.Create(new Task
                        {
                            Subject = "Follow up",
                            Description = "Follow up with the customer",
                            ActualStart = contact.odx_nextcontactdate.Value, 
                            RegardingObjectId = new EntityReference(Contact.EntityLogicalName, contact.Id)
                        }); 
                    }

                }
            }
        }
    }
}
