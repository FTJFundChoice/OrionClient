using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using FTJFundChoice.OrionModels.Portfolio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class RepresentativesModule : IRepresentativesModule {
        private Client client = null;

        public RepresentativesModule(Client client) {
            this.client = client;
        }

        /// <summary>
        /// Creates a new Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public async Task<IResult<RepresentativeVerbose>> Create(RepresentativeVerbose representative) {
            var request = new Request("Portfolio/Representatives/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(representative));

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }

        public Task<IResult> Delete(long[] id) {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<RepresentativeVerbose>> Get(long id) {
            return await Get(id, true, false);
        }

        public async Task<IResult<RepresentativeVerbose>> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new Request("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            request.AddExpandQueryParameters(includePorfolio, includeUserDefinedFields);

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAll() {
            return await GetAll(5000, 0, null, true, false);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAll(int top = 1000, int skip = 0, bool? isActive = null) {
            return await GetAll(top, skip, null, true, false);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAll(int top = 1000, int skip = 0, bool? isActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new Request("Portfolio/Representatives/Verbose", Method.GET);
            request.AddExpandQueryParameters(includePorfolio, includeUserDefinedFields);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);

            return await client.ExecuteTaskAsync<List<RepresentativeVerbose>>(request);
        }

        /// <summary>
        /// Updates a Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public async Task<IResult<RepresentativeVerbose>> Update(RepresentativeVerbose representative) {
            var request = new Request("Portfolio/Representatives/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", representative.Id.ToString());

            // hopefully a temporary fix, the portfolio.id is not populated on the GET request.
            representative.Portfolio.Id = representative.Id;

            request.AddParameter("application/json", JsonConvert.SerializeObject(representative));

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }
    }
}