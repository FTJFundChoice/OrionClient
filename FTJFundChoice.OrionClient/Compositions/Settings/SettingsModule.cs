using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Interfaces.Settings;
using FTJFundChoice.OrionClient.Models.Portfolio;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using FTJFundChoice.OrionClient.Models.Settings;

namespace FTJFundChoice.OrionClient.Compositions.Settings
{
    public class SettingsModule : ISettingsModule
    {
        private OrionApiClient client = null;
        public SettingsModule (OrionApiClient client)
        {
            this.client = client;
        }      

        public async Task<IResult<BrokerDealerVerbose>> UploadBrokerDealerLogo(string entityType, long entityId, byte[] brokerDealerLogo)
        {
            var request = new Request("Settings/CustomSettings/theme-main-logo?entity={entityType}&entityId={entityId}", Method.PUT);

            request.AddUrlSegment("entityType", entityType);
            request.AddUrlSegment("entityId", entityId.ToString());

            var logo = new MainThemeLogo()
            {
                ImageStream = brokerDealerLogo
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(logo));
            //request.AddParameter(mimeType, brokerDealerLogo.ToString());

            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }
    }
}
