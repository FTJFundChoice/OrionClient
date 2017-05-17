using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class PlanSponsorsModule : IPlanSponsorsModule {
        private OrionApiClient client = null;

        public PlanSponsorsModule(OrionApiClient client) {
            this.client = client;
        }

        public Task<IResult<PlanSponsorSimple>> GetAsync(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<PlanSponsorSimple>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/PlanSponsors/Simple", Method.GET);

            request.AddTopSkipQueryParameters(top, skip);
            return await client.ExecuteTaskAsync<IEnumerable<PlanSponsorSimple>>(request);
        }
    }
}