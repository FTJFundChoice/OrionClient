using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class WholesalerModule : IWholesalerModule {
        private IRestClient client = null;

        public WholesalerModule(IRestClient client) {
            this.client = client;
        }

        public async Task<IResult<Wholesaler>> Get(long id) {
            var request = new RestRequest("Portfolio/Wholesalers/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = await client.ExecuteTaskAsync<Wholesaler>(request);
            return new Result<Wholesaler>(result);
        }

        public async Task<IResult<List<Wholesaler>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestRequest("Portfolio/Wholesalers", Method.GET);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);
            var result = await client.ExecuteTaskAsync<List<Wholesaler>>(request);
            return new Result<List<Wholesaler>>(result);
        }
    }
}