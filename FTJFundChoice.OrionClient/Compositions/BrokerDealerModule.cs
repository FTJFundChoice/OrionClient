using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels.Portfolio;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class BrokerDealerModule : IBrokerDealerModule {
        private IRestClient client = null;

        public BrokerDealerModule(IRestClient client) {
            this.client = client;
        }

        public async Task<IResult<BrokerDealer>> Create(BrokerDealer brokerDealer) {
            var request = new OrionRequest("Portfolio/BrokerDealers/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }

        public async Task<IResult<BrokerDealer>> Get(long id) {
            var request = new OrionRequest("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = await client.ExecuteTaskAsync<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }

        public async Task<IResult<List<BrokerDealer>>> GetAll() {
            var request = new OrionRequest("Portfolio/BrokerDealers/Verbose", Method.GET);
            var result = await client.ExecuteTaskAsync<List<BrokerDealer>>(request);
            return new Result<List<BrokerDealer>>(result);
        }

        public async Task<IResult<BrokerDealer>> Update(BrokerDealer brokerDealer) {
            var request = new OrionRequest("Portfolio/BrokerDealers/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", brokerDealer.Id.ToString());

            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }
    }
}