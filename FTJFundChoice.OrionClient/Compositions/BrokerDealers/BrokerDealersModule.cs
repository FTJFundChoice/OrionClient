using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels.Portfolio;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace FTJFundChoice.OrionClient.Compositions {

    public class BrokerDealersModule : IBrokerDealersModule {
        private Client client = null;

        public BrokerDealersModule(Client client) {
            this.client = client;
        }

        public async Task<IResult<BrokerDealerVerbose>> Create(BrokerDealerVerbose brokerDealer) {
            var request = new Request("Portfolio/BrokerDealers/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer));

            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }

        public async Task<IResult<BrokerDealerVerbose>> Get(long id) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }

        public async Task<IResult<List<BrokerDealerVerbose>>> GetAll() {
            return await GetAll(1000, 0);
        }

        public Task<IResult<List<BrokerDealerVerbose>>> GetAll(int top = 1000, int skip = 0) {
            var request = new Request("Portfolio/BrokerDealers/Verbose", Method.GET);
            return await client.ExecuteTaskAsync<List<BrokerDealerVerbose>>(request);
        }

        public async Task<IResult<BrokerDealerVerbose>> Update(BrokerDealerVerbose brokerDealer) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", brokerDealer.Id.ToString());

            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer));

            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }
    }
}