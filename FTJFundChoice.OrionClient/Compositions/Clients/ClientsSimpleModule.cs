﻿using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces.Clients;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions.Clients {

    public class ClientSimpleModule : IClientsSimpleModule {
        private readonly OrionApiClient client = null;

        public ClientSimpleModule(OrionApiClient client) {
            this.client = client;
        }

        public async Task<IResult<ClientSimple>> GetAsync(long id) {
            var request = new Request("Portfolio/Clients/{id}/Simple", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<ClientSimple>(request);
        }

        public async Task<IResult<IEnumerable<ClientSimple>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/Clients/Simple", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<IEnumerable<ClientSimple>>(request);
        }

        public async Task<IResult<IEnumerable<ClientSimple>>> SearchAsync(string search) {
            var request = new Request("Portfolio/Clients/Simple/Search/{search}", Method.GET);
            request.AddUrlSegment("search", search.ToString());
            return await client.ExecuteTaskAsync<IEnumerable<ClientSimple>>(request);
        }
    }
}