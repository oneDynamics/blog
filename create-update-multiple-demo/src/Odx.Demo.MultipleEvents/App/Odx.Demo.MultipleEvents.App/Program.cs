using Bogus;
using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Odx.Demo.MultipleEvents.Common.Model;
using System;

public class App
{
    public static void Main(string[] args) {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();

        var operationCount = Int32.Parse(configuration["AppSettings:OperationCount"]);
        var operationType = configuration["AppSettings:OperationType"];
        var url = configuration["AppSettings:Url"];
        var appId = configuration["AppSettings:AppId"];
        var appSecret = configuration["AppSettings:AppSecret"];

        // Connection string to your Dataverse environment.
        string connectionString = $"AuthType=ClientSecret;Url={url};ClientId={appId};ClientSecret={appSecret}";

        using (var serviceClient = new ServiceClient(connectionString))
        {
            if (serviceClient.IsReady)
            {
                if (operationType == "create")
                {
                    var request = new CreateMultipleRequest(); 
                    request.Targets = new EntityCollection();
                    for(int i = 0; i < operationCount; i++)
                    {
                        request.Targets.Entities.Add(GetRandomContact()); 
                    }

                }
                else if (operationType == "update")
                {
                    //TODO: Implement update operation
                }
            }
        }



    }

    private static Contact GetRandomContact()
    {
        var person = new Person();

        return new Contact
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
            odx_nextcontactdate = GetRandomDate()
        }; 
    }
    private static DateTime GetRandomDate()
    {
        Random rand = new Random();
        DateTime baseDate = new DateTime(2000, 1, 1);
        int range = (DateTime.Today - baseDate).Days;
        return baseDate.AddDays(rand.Next(range));
    }

}
