using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions.BrokerDealers {

    public class BrokerDealersSimpleModule : IBrokerDealersSimpleModule {
        private OrionApiClient client = null;

        public BrokerDealersSimpleModule(OrionApiClient client) {
            this.client = client;
        }

        public async Task<IResult<IEnumerable<BrokerDealerSimple>>> SearchAsync(string search) {
            var request = new Request("Portfolio/BrokerDealers/Simple/{search}", Method.GET);
            request.AddUrlSegment("search", search.ToString());
            return await client.ExecuteTaskAsync<IEnumerable<BrokerDealerSimple>>(request);
        }

        public async Task<IResult<IEnumerable<BrokerDealer>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/BrokerDealers", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<IEnumerable<BrokerDealer>>(request);
        }
    }
}