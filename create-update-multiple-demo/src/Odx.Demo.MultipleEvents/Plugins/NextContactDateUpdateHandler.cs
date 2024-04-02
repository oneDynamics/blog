using Microsoft.Xrm.Sdk;
using Odx.Demo.MultipleEvents.Common.Model;
using System;

namespace Odx.Demo.MultipleEvents.Plugins
{
    public class NextContactDateUpdateHandler : PluginBase
    {
        public NextContactDateUpdateHandler(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(NextContactDateUpdateHandler))
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
                    if(contact.odx_nextcontactdate.HasValue)
                    {
                        var contactPreImage = ((Entity)context.PreEntityImages["PreImage"]).ToEntity<Contact>();
                        localPluginContext.InitiatingUserService.Create(new Task
                        {
                            Subject = "Follow up",
                            Description = "Follow up with the customer",
                            ActualStart = contact.odx_nextcontactdate.Value, 
                            OwnerId = contactPreImage?.OwnerId 
                                ?? new EntityReference(SystemUser.EntityLogicalName, context.InitiatingUserId)
                        }); 
                    }

                }
            }
        }
    }
}
