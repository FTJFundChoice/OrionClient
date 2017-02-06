using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions.BrokerDealers {

    public class BrokerDealersSimpleModule : IBrokerDealersSimpleModule {
        private Client client = null;

        public BrokerDealersSimpleModule(Client client) {
            this.client = client;
        }

        public async Task<IResult<List<BrokerDealerSimple>>> Search(string search) {
            var request = new Request("Portfolio/BrokerDealers/Simple/{search}", Method.GET);
            request.AddUrlSegment("search", search.ToString());
            return await client.ExecuteTaskAsync<List<BrokerDealerSimple>>(request);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAll(int top = 1000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/BrokerDealers", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<List<BrokerDealer>>(request);
        }
    }
}