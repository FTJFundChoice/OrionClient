using FTJFundChoice.OrionClient.Compositions.BrokerDealers;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionModels.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class BrokerDealersModule : IBrokerDealersModule {
        private Client client = null;
        private IBrokerDealersVerboseModule verboseModule = null;
        private IBrokerDealersSimpleModule simpleModule = null;

        public BrokerDealersModule(Client client) {
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

        public async Task<IResult<BrokerDealer>> Get(long id) {
            var request = new Request("Portfolio/BrokerDealers/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<BrokerDealer>(request);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAll() {
            return await GetAll(1000, 0, true);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAll(int top = 1000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/BrokerDealers", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<List<BrokerDealer>>(request);
        }
    }
}