using FTJFundChoice.OrionClient.Interfaces.SubAdvisors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;

namespace FTJFundChoice.OrionClient.Compositions.SubAdvisors {

    public class SubAdvisorsModule : ISubAdvisorsModule {
        private OrionApiClient client = null;

        public SubAdvisorsModule(OrionApiClient client) {
            this.client = client;
        }

        public ISubAdvisorsSimpleModule Simple {
            get {
                return new SubAdvisorsSimpleModule(client);
            }
        }

        public async Task<IResult<SubAdvisor>> GetAsync(long id) {
            var request = new Request("Portfolio/SubAdvisors/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));

            return await client.ExecuteTaskAsync<SubAdvisor>(request);
        }

        public async Task<IResult<List<SubAdvisor>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/SubAdvisors", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);

            return await client.ExecuteTaskAsync<List<SubAdvisor>>(request);
        }
    }
}