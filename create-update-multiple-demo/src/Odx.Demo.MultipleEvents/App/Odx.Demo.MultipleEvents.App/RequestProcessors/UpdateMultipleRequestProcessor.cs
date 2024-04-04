using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Odx.Demo.MultipleEvents.App.Internal;
using Odx.Demo.MultipleEvents.Common.Model;
using System.Diagnostics;

namespace Odx.Demo.MultipleEvents.App.RequestProcessors
{
    public class UpdateMultipleRequestProcessor : ProcessorBase
    {
        public UpdateMultipleRequestProcessor(ServiceClient serviceClient, int operationCount) : base(serviceClient, operationCount)
        {
        }

        public override int MeasureRequestTime()
        {        
            var responseEntities = GetTopContactRecords(this.operationCount);
            if (responseEntities.Count == 0)
            {
                Console.WriteLine("No records found to update");
                return 0;
            }

            var request = new UpdateMultipleRequest();
            request.Targets = new EntityCollection();
            request.Targets.EntityName = Contact.EntityLogicalName;

            foreach (var entity in responseEntities)
            {
                var contact = RandomContactGenerator.Get();
                contact.Id = entity.Id;
                request.Targets.Entities.Add(contact);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine($"Request execution started");
            serviceClient.Execute(request);
            
            stopwatch.Stop();
            
            return (int)stopwatch.Elapsed.TotalSeconds; 
        }
    }
}
