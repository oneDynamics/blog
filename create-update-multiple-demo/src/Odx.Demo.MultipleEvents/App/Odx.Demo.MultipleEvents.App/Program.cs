using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using Odx.Demo.MultipleEvents.App.Internal;
using Odx.Demo.MultipleEvents.App.RequestProcessors;

public class App
{
    public static void Main(string[] args) {
        Console.WriteLine($"Application started");

        var configurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var config = new Config(configurationRoot);

        string connectionString = $"AuthType=ClientSecret;Url={config.Url};ClientId={config.AppId};ClientSecret={config.AppSecret}";

        using (var serviceClient = new ServiceClient(connectionString ))
        {
            if (serviceClient.IsReady && !config.IndividualRequests)
            {
                if (config.OperationType == "create")
                {
                    Console.WriteLine("operationType == create (!I)");
                    var totalSeconds = new CreateMultipleRequestProcessor(serviceClient, config.OperationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}"); 
                }
                else if (config.OperationType == "update")
                {
                    Console.WriteLine("operationType == update  (!I)");
                    var totalSeconds = new UpdateMultipleRequestProcessor(serviceClient, config.OperationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
            }
            else if(serviceClient.IsReady && config.IndividualRequests)
            {
                if (config.OperationType == "create")
                {
                    Console.WriteLine("operationType == create (I)");
                    var totalSeconds = new CreateRequestProcessor(serviceClient, config.OperationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
                else if (config.OperationType == "update")
                {
                    Console.WriteLine("operationType == update (I)");
                    var totalSeconds = new UpdateRequestProcessor(serviceClient, config.OperationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
            }       
        }
    }
}
