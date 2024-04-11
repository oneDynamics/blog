using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Odx.Demo.MultipleEvents.Common.Model;

namespace Odx.Demo.MultipleEvents.App.RequestProcessors
{
    public abstract class ProcessorBase
    {
        protected ServiceClient serviceClient;
        protected int operationCount;

        public ProcessorBase(ServiceClient serviceClient, int operationCount)
        {
            this.serviceClient = serviceClient;
            this.operationCount = operationCount;
        }

        public abstract int MeasureRequestTime(); 

        public DataCollection<Entity> GetTopContactRecords(int top)
        {
            var response = (RetrieveMultipleResponse)serviceClient.Execute(
                       new RetrieveMultipleRequest()
                       {
                           Query = new QueryExpression(Contact.EntityLogicalName)
                           {
                               ColumnSet = new ColumnSet(Contact.Fields.ContactId),
                               TopCount = top
                           }
                       });
            return response.EntityCollection.Entities; 
        }
    }
}
