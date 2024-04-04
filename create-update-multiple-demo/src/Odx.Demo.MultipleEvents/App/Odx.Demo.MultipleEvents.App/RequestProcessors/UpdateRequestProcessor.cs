using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk.Messages;
using Odx.Demo.MultipleEvents.App.Internal;
using System.Diagnostics;


namespace Odx.Demo.MultipleEvents.App.RequestProcessors
{
    public class UpdateRequestProcessor : ProcessorBase
    {
        public UpdateRequestProcessor(ServiceClient serviceClient, int operationCount) : base(serviceClient, operationCount)
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

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var entity in responseEntities)
            {
                var request = new UpdateRequest();
                request.Target = RandomContactGenerator.Get();
                request.Target.Id = entity.Id; 
                serviceClient.Execute(request);
            }

            stopwatch.Stop();

            return (int)stopwatch.Elapsed.TotalSeconds;
        }
    }
}
