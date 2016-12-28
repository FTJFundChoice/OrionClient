using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using FTJFundChoice.OrionModels.Portfolio;
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
            var request = new OrionRequest("Portfolio/Representatives/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(representative), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }

        public async Task<IResult<Representative>> Get(long id) {
            return await Get(id, true, false);
        }

        public async Task<IResult<Representative>> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new OrionRequest("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            request.AddExpandQueryParameters(includePorfolio, includeUserDefinedFields);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }

        public async Task<IResult<List<Representative>>> GetAll() {
            return await GetAll(5000, 0, null, true, false);
        }

        public async Task<IResult<List<Representative>>> GetAll(int top = 1000, int skip = 0, bool? isActive = null) {
            return await GetAll(top, skip, null, true, false);
        }

        public async Task<IResult<List<Representative>>> GetAll(int top = 1000, int skip = 0, bool? isActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new OrionRequest("Portfolio/Representatives/Verbose", Method.GET);
            request.AddExpandQueryParameters(includePorfolio, includeUserDefinedFields);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);

            var result = await client.ExecuteTaskAsync<List<Representative>>(request);
            return new Result<List<Representative>>(result);
        }

        /// <summary>
        /// Updates a Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public async Task<IResult<Representative>> Update(Representative representative) {
            var request = new OrionRequest("Portfolio/Representatives/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", representative.Id.ToString());

            // hopefully a temporary fix, the portfolio.id is not populated on the GET request.
            representative.Portfolio.Id = representative.Id;

            request.AddParameter("application/json", JsonConvert.SerializeObject(representative), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<Representative>(request);
            return new Result<Representative>(result);
        }
    }
}