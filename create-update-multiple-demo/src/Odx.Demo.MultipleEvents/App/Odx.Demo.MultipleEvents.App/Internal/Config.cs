using Microsoft.Extensions.Configuration;

namespace Odx.Demo.MultipleEvents.App.Internal
{
    internal class Config
    {
        internal int OperationCount { get; private set; }
        internal string OperationType { get; private set; }
        internal string Url { get; private set; }
        internal string AppId { get; private set; }
        internal string AppSecret { get; private set; }
        internal bool IndividualRequests { get; private set; }

        internal Config(IConfigurationRoot configurationRoot)
        {
            OperationCount = Int32.Parse(configurationRoot["AppSettings:OperationCount"]);
            OperationType = configurationRoot["AppSettings:OperationType"];
            Url = configurationRoot["AppSettings:Url"];
            AppId = configurationRoot["AppSettings:AppId"];
            AppSecret = configurationRoot["AppSettings:AppSecret"];
            IndividualRequests = Boolean.Parse(configurationRoot["AppSettings:IndividualRequests"]);
        }
    }
}
