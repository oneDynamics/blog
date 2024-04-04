using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using Odx.Demo.MultipleEvents.App.RequestProcessors;

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
                    var totalSeconds = new CreateMultipleRequestProcessor(serviceClient, operationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}"); 
                }
                else if (operationType == "update")
                {
                    Console.WriteLine("operationType == update  (!I)");
                    var totalSeconds = new UpdateMultipleRequestProcessor(serviceClient, operationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
            }
            else if(serviceClient.IsReady && individualRequests)
            {
                if (operationType == "create")
                {
                    Console.WriteLine("operationType == create (I)");
                    var totalSeconds = new CreateRequestProcessor(serviceClient, operationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
                else if (operationType == "update")
                {
                    Console.WriteLine("operationType == update (I)");
                    var totalSeconds = new UpdateRequestProcessor(serviceClient, operationCount).MeasureRequestTime();
                    Console.WriteLine($"Time elapsed in seconds: {totalSeconds}");
                }
            }       
        }
    }
}
