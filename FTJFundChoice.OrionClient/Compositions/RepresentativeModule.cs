using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Compositions {

    public class RepresentativeModule : IRepresentativeModule {
        private IRestClient client = null;

        public RepresentativeModule(IRestClient client) {
            this.client = client;
        }

        /// <summary>
        /// Creates a new Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public Result<Representative> Create(Representative representative) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.POST);
            request.AddParameter("application/json", SimpleJson.SerializeObject(representative, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<Representative>(request);
            return new Result<Representative>(result);
        }

        public Result<Representative> Get(long id) {
            return Get(id, true, false);
        }

        public Result<Representative> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);

            var result = client.Execute<Representative>(request);
            return new Result<Representative>(result);
        }

        public Result<List<Representative>> GetAll(int top = 1000, int skip = 0, bool? IsActive = null) {
            return GetAll(top, skip, null, true, false);
        }

        public Result<List<Representative>> GetAll(int top = 100, int skip = 0, bool? IsActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.GET);
            if (IsActive.HasValue)
                request.AddQueryParameter("isActive", IsActive.Value ? "1" : "0");

            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = client.Execute<List<Representative>>(request);
            return new Result<List<Representative>>(result);
        }

        /// <summary>
        /// Updates a Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public Result<Representative> Update(Representative representative) {
            var request = new RestRequest("Portfolio/Representatives/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", representative.Id.ToString());

            // hopefully a temporary fix, the portfolio.id is not populated on the GET request.
            representative.Portfolio.Id = representative.Id;

            request.AddParameter("application/json", SimpleJson.SerializeObject(representative, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<Representative>(request);
            return new Result<Representative>(result);
        }
    }
}