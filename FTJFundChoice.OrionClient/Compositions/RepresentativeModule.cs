using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IResult<Representative>> Create(Representative representative) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/Representatives/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(representative), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }

        public async Task<IResult<Representative>> Get(long id) {
            return await Get(id, true, false);
        }

        public async Task<IResult<Representative>> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }

        public async Task<IResult<List<Representative>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = null) {
            return await GetAll(top, skip, null, true, false);
        }

        public async Task<IResult<List<Representative>>> GetAll(int top = 100, int skip = 0, bool? IsActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new RestRequest("Portfolio/Representatives/Verbose", Method.GET);
            if (IsActive.HasValue)
                request.AddQueryParameter("isActive", IsActive.Value ? "1" : "0");

            QueryHelpers.AddExpandQueryParameters(request, includePorfolio, includeUserDefinedFields);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = await client.ExecuteTaskAsync<List<Representative>>(request);
            return new Result<List<Representative>>(result);
        }

        /// <summary>
        /// Updates a Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public async Task<IResult<Representative>> Update(Representative representative) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Portfolio/Representatives/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", representative.Id.ToString());

            // hopefully a temporary fix, the portfolio.id is not populated on the GET request.
            representative.Portfolio.Id = representative.Id;

            request.AddParameter("application/json", JsonConvert.SerializeObject(representative), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }
    }
}