using FTJFundChoice.OrionClient.Compositions.BrokerDealers;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions.BrokerDealers {

    public class BrokerDealersModule : IBrokerDealersModule {
        private OrionApiClient client = null;
        private IBrokerDealersVerboseModule verboseModule = null;
        private IBrokerDealersSimpleModule simpleModule = null;

        public BrokerDealersModule(OrionApiClient client) {
            this.client = client;
            verboseModule = new BrokerDealersVerboseModule(client);
            simpleModule = new BrokerDealersSimpleModule(client);
        }

        public IBrokerDealersSimpleModule Simple {
            get {
                return simpleModule;
            }
        }

        public IBrokerDealersVerboseModule Verbose {
            get {
                return verboseModule;
            }
        }

        public async Task<IResult<BrokerDealer>> GetAsync(long id) {
            var request = new Request("Portfolio/BrokerDealers/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<BrokerDealer>(request);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAllAsync() {
            return await GetAllAsync(10000, 0, true);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/BrokerDealers", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<List<BrokerDealer>>(request);
        }
    }
}