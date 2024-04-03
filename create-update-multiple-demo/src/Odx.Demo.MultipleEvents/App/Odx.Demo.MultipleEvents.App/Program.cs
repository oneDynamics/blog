using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Odx.Demo.MultipleEvents.App;
using Odx.Demo.MultipleEvents.Common.Model;
using System.Diagnostics;

public class App
{
    public static void Main(string[] args) {
        Console.WriteLine($"Application started");

        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();

        var operationCount = Int32.Parse(configuration["AppSettings:OperationCount"]);
        var operationType = configuration["AppSettings:OperationType"];
        var url = configuration["AppSettings:Url"];
        var appId = configuration["AppSettings:AppId"];
        var appSecret = configuration["AppSettings:AppSecret"];
        var individualRequests = Boolean.Parse(configuration["AppSettings:IndividualRequests"]);

        // Connection string to your Dataverse environment.
        string connectionString = $"AuthType=ClientSecret;Url={url};ClientId={appId};ClientSecret={appSecret}";

        using (var serviceClient = new ServiceClient(connectionString ))
        {
            if (serviceClient.IsReady && !individualRequests)
            {
                if (operationType == "create")
                {
                    Console.WriteLine("operationType == create (!I)");
                    Stopwatch stopwatch = new Stopwatch();
                    var request = new CreateMultipleRequest(); 
                    request.Targets = new EntityCollection();
                    request.Targets.EntityName = Contact.EntityLogicalName;
                    for (int i = 0; i < operationCount; i++)
                    {
                        request.Targets.Entities.Add((Entity)RandomContactGenerator.Get()); 
                    }
                    stopwatch.Start();
                    Console.WriteLine($"Request execution started");
                    serviceClient.Execute(request);
                    stopwatch.Stop();
                    Console.WriteLine($"Time elapsed in seconds: {stopwatch.Elapsed.TotalSeconds}");


                }
                else if (operationType == "update")
                {
                    Console.WriteLine("operationType == update  (!I)");
                    Stopwatch stopwatch = new Stopwatch();
                    var response = (RetrieveMultipleResponse)serviceClient.Execute(new RetrieveMultipleRequest()
                    {
                        Query = new QueryExpression(Contact.EntityLogicalName)
                        {
                            ColumnSet = new ColumnSet(Contact.Fields.ContactId), 
                            TopCount = operationCount
                        }
                    });

                    if(response.EntityCollection.Entities.Count == 0)
                    {
                        Console.WriteLine("No records found to update");
                        return;
                    }
                    var request = new UpdateMultipleRequest();
                    request.Targets = new EntityCollection(); 
                    request.Targets.EntityName = Contact.EntityLogicalName;
                    foreach (var entity in response.EntityCollection.Entities)
                    {
                        var contact = RandomContactGenerator.Get(); 
                        contact.Id = entity.Id;
                        request.Targets.Entities.Add(contact);
                    }
                    stopwatch.Start();
                    Console.WriteLine($"Request execution started");
                    serviceClient.Execute(request);
                    stopwatch.Stop();
                    Console.WriteLine($"Time elapsed in seconds: {stopwatch.Elapsed.TotalSeconds}");
                }
            }
            else if(serviceClient.IsReady && individualRequests)
            {
                if (operationType == "create")
                {
                    Console.WriteLine("operationType == create (I)");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    for (int i = 0; i < operationCount; i++)
                    {
                        var request = new CreateRequest();
                        request.Target = RandomContactGenerator.Get(); 
                        serviceClient.Execute(request);
 
                    }
                    stopwatch.Stop();
                    Console.WriteLine($"Time elapsed in seconds: {stopwatch.Elapsed.TotalSeconds}");
                }
                else if (operationType == "update")
                {
                    Console.WriteLine("operationType == update (I)");

                    var response = (RetrieveMultipleResponse)serviceClient.Execute(
                        new RetrieveMultipleRequest()
                        {
                            Query = new QueryExpression(Contact.EntityLogicalName)
                            {
                                ColumnSet = new ColumnSet(Contact.Fields.ContactId),
                                TopCount = operationCount
                            }
                        });

                    if (response.EntityCollection.Entities.Count == 0)
                    {
                        Console.WriteLine("No records found to update");
                        return;
                    }
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    foreach (var entity in response.EntityCollection.Entities)
                    {
                        var request = new UpdateRequest();
                        var contact = RandomContactGenerator.Get();
                        contact.Id = entity.Id;
                        request.Target = contact;
                        serviceClient.Execute(request);
                    }
                    stopwatch.Stop();
                    Console.WriteLine($"Time elapsed in seconds: {stopwatch.Elapsed.TotalSeconds}");
                }
            }       
        }
    }
}
