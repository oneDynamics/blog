using Microsoft.Xrm.Sdk;
using Odx.Demo.MultipleEvents.Common.Model;
using System;

namespace Odx.Demo.MultipleEvents.Plugins
{
    public class MultipleNextContactDatesHandler : PluginBase
    {
        public MultipleNextContactDatesHandler(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(MultipleNextContactDatesHandler))
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
                for (var i = 0; i < entityCollection.Entities.Count; i++)
                {
                    var entity = entityCollection.Entities[i];  
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
}
