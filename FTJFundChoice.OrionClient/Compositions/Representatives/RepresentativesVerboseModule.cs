﻿using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.Representatives;
using FTJFundChoice.OrionClient.Models.Portfolio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions.Representatives {

    public class RepresentativesVerboseModule : IRepresentativesVerboseModule {
        private OrionApiClient client = null;

        public RepresentativesVerboseModule(OrionApiClient client) {
            this.client = client;
        }

        /// <summary>
        /// Creates a new Representative.
        /// </summary>
        /// <param name="representative"></param>
        /// <returns>Returns Result object with verbose Representative. (no collections)</returns>
        public async Task<IResult<RepresentativeVerbose>> CreateAsync(RepresentativeVerbose representative) {
            var request = new Request("Portfolio/Representatives/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(representative));

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }

        public Task<IResult> DeleteAsync(long[] id) {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<RepresentativeVerbose>> GetAsync(long id) {
            return await GetAsync(id, true, false);
        }

        public async Task<IResult<RepresentativeVerbose>> GetAsync(long id, bool includePorfolio = true, bool includeUserDefinedFields = false) {
            var request = new Request("Portfolio/Representatives/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
            request.AddExpandQueryParameters(includePorfolio, includeUserDefinedFields);

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAll() {
            return await GetAllAsync(10000, 0, null, true, false);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = null) {
            return await GetAllAsync(top, skip, null, true, false);
        }

        public async Task<IResult<List<RepresentativeVerbose>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = null, bool includePorfolio = true, bool includeUserDefinedFields = false) {
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
        public async Task<IResult<RepresentativeVerbose>> UpdateAsync(RepresentativeVerbose representative) {
            var request = new Request("Portfolio/Representatives/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", representative.Id.ToString());

            // hopefully a temporary fix, the portfolio.id is not populated on the GET request.
            representative.Portfolio.Id = representative.Id;

            request.AddParameter("application/json", JsonConvert.SerializeObject(representative));

            return await client.ExecuteTaskAsync<RepresentativeVerbose>(request);
        }
    }
}