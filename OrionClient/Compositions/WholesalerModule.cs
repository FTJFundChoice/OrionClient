using OrionClient.Helpers;
using OrionClient.Interfaces;
using OrionClient.Model.Models;
using RestSharp;
using System;
using System.Collections.Generic;

namespace OrionClient.Compositions {

    public class WholesalerModule : IWholesalerModule {
        private IRestClient client = null;

        public WholesalerModule(IRestClient client) {
            this.client = client;
        }

        public Result<List<Wholesaler>> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestRequest("Portfolio/Wholesalers", Method.GET);
            var result = client.Execute<List<Wholesaler>>(request);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            return new Result<List<Wholesaler>>(result);
        }

        public Result<Wholesaler> Get(long id) {
            var request = new RestRequest("Portfolio/Wholesalers/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = client.Execute<Wholesaler>(request);
            return new Result<Wholesaler>(result);
        }

        public Result<Wholesaler> Create(Wholesaler representative) {
            throw new NotImplementedException();
        }

        public Result<Wholesaler> Update(Wholesaler representative) {
            throw new NotImplementedException();
        }
    }
}