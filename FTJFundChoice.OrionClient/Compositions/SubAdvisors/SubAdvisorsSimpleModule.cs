using FTJFundChoice.OrionClient.Interfaces.SubAdvisors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Enums;

namespace FTJFundChoice.OrionClient.Compositions.SubAdvisors {

    public class SubAdvisorsSimpleModule : ISubAdvisorsSimpleModule {
        private OrionApiClient client = null;

        public SubAdvisorsSimpleModule(OrionApiClient client) {
            this.client = client;
        }

        public Task<IResult<SubAdvisorSimple>> GetAsync(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<SubAdvisorSimple>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/SubAdvisors/Simple", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);

            return await client.ExecuteTaskAsync<IEnumerable<SubAdvisorSimple>>(request);
        }
    }
}