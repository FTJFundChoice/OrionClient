using FTJFundChoice.OrionClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Enums;

namespace FTJFundChoice.OrionClient.Compositions {

    public class ThirdPartyAdministratorsModule : IThirdPartyAdministratorsModule {
        private OrionApiClient client = null;

        public ThirdPartyAdministratorsModule(OrionApiClient client) {
            this.client = client;
        }

        public Task<IResult<ThirdPartyAdministratorSimple>> GetAsync(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<ThirdPartyAdministratorSimple>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/ThirdPartyAdministrators/Simple", Method.GET);

            request.AddTopSkipQueryParameters(top, skip);
            return await client.ExecuteTaskAsync<IEnumerable<ThirdPartyAdministratorSimple>>(request);
        }
    }
}