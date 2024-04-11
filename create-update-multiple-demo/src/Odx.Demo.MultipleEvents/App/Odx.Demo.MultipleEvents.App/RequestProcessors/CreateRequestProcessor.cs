using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk.Messages;
using Odx.Demo.MultipleEvents.App.Internal;
using System.Diagnostics;


namespace Odx.Demo.MultipleEvents.App.RequestProcessors
{
    public class CreateRequestProcessor : ProcessorBase
    {
        public CreateRequestProcessor(ServiceClient serviceClient, int operationCount) : base(serviceClient, operationCount)
        {
        }

        public override int MeasureRequestTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < operationCount; i++)
            {
                var request = new CreateRequest();
                request.Target = RandomContactGenerator.Get();
                serviceClient.Execute(request);

            }

            stopwatch.Stop();

            return (int)stopwatch.Elapsed.TotalSeconds;
        }
    }
}
