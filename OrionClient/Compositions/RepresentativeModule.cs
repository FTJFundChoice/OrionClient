using OrionClient.Helpers;
using OrionClient.Interfaces;
using OrionClient.Model;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;

namespace OrionClient.Compositions {

    public class RepresentativeModule : IRepresentativeModule {
        private IRestClient client = null;

        public RepresentativeModule(IRestClient client) {
            this.client = client;
        }

        public IEnumerable<Representative> GetAll(int top = 1000, int skip = 0, bool? IsActive = null) {
            return GetAll(top, skip, null, true, false);
        }

        public IEnumerable<Representative> GetAll(int top = 100, int skip = 0, bool? IsActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.GET);
            if (IsActive.HasValue)
                request.AddQueryParameter("isActive", IsActive.Value ? "1" : "0");

            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = client.Execute<List<Representative>>(request);
            return result.Data;
        }

        public Representative Get(long id) {
            return Get(id, true, false);
        }

        public Representative Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);

            var result = client.Execute<Representative>(request);
            return result.Data;
        }

        public Representative Create(Representative representative) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.POST);
            //request.AddObject(representative);

            request.AddParameter("application/json", SimpleJson.SerializeObject(representative, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<Representative>(request);
            return result.Data;
        }

        public Representative Update(Representative representative) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.PUT);
            request.AddObject(representative);

            var result = client.Execute<Representative>(request);
            return result.Data;
        }
    }
}