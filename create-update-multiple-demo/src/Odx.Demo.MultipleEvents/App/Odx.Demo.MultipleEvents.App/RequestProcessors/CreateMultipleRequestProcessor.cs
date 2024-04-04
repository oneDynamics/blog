using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Odx.Demo.MultipleEvents.App.Internal;
using Odx.Demo.MultipleEvents.Common.Model;
using System.Diagnostics;

namespace Odx.Demo.MultipleEvents.App.RequestProcessors
{
    public class CreateMultipleRequestProcessor : ProcessorBase
    {
        public CreateMultipleRequestProcessor(ServiceClient serviceClient, int operationCount) : base(serviceClient, operationCount)
        {
        }

        public override int MeasureRequestTime()
        {       
            var request = new CreateMultipleRequest();
            request.Targets = new EntityCollection();
            request.Targets.EntityName = Contact.EntityLogicalName;

            for (int i = 0; i < operationCount; i++)
            {
                request.Targets.Entities.Add((Entity)RandomContactGenerator.Get());
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
