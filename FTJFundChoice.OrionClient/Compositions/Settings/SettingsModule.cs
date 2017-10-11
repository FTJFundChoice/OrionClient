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

        public async Task<IResult> UploadMainThemeLogo(string entityType, long entityId, string logoData)
        {
            var request = new Request($"Settings/CustomSettings/theme-main-logo?entity={entityType}&entityId={entityId}", Method.PUT);

            var logo = new Logo()
            {
                ImageStream = logoData,
                PromptName = "theme-main-logo",
                Category = "global",
                CustomAppSetting = "ClientPortal"
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(logo));
            //request.AddParameter(mimeType, brokerDealerLogo.ToString());

            return await client.ExecuteTaskAsync<Result>(request);
        }

        public async Task<IResult> UploadAdvisorImage(string entityType, long entityId, string logoData)
        {
            var request = new Request($"Settings/CustomSettings/advisor-image/Image?entity={entityType}&entityId={entityId}", Method.PUT);

            var logo = new Logo()
            {
                ImageStream = logoData,
                PromptName = "advisor-image",
                Category = "global",
                CustomAppSetting = "ClientPortal"
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(logo));
            //request.AddParameter(mimeType, brokerDealerLogo.ToString());

            return await client.ExecuteTaskAsync<Result>(request);
        }
    }
}
