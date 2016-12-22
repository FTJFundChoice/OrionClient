using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Compositions {

    public class BrokerDealerModule : IBrokerDealerModule {
        private IRestClient client = null;

        public BrokerDealerModule(IRestClient client) {
            this.client = client;
        }

        public Result<BrokerDealer> Create(BrokerDealer brokerDealer) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/BrokerDealers/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer), ParameterType.RequestBody);

            var result = client.Execute<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }

        public Result<BrokerDealer> Get(long id) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = client.Execute<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }

        public Result<List<BrokerDealer>> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/BrokerDealers/Verbose", Method.GET);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = client.Execute<List<BrokerDealer>>(request);
            return new Result<List<BrokerDealer>>(result);
        }

        public Result<BrokerDealer> Update(BrokerDealer brokerDealer) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/BrokerDealers/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", brokerDealer.Id.ToString());

            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer), ParameterType.RequestBody);

            var result = client.Execute<BrokerDealer>(request);
            return new Result<BrokerDealer>(result);
        }
    }
}