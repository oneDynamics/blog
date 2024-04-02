using Microsoft.Xrm.Sdk;
using Odx.Demo.MultipleEvents.Common.Model;
using System;

namespace Odx.Demo.MultipleEvents.Plugins
{
    internal class MultipleNextContactDatesHandler : PluginBase
    {
        public MultipleNextContactDatesHandler(Type pluginClassName) : base(pluginClassName)
        {
        }

        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;

            if (context.InputParameters.Contains("Targets") && context.InputParameters["Targets"] is EntityCollection entityCollection)
            {
                // Verify expected entity images from step registration
                foreach (Entity entity in entityCollection.Entities)
                {
                    if (entity.LogicalName == Contact.EntityLogicalName)
                    {
                        var contact = entity.ToEntity<Contact>();
                        if (contact.odx_nextcontactdate.HasValue)
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
}
