﻿using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class ProfilesModule : IProfilesModule {
        private OrionApiClient client = null;

        public ProfilesModule(OrionApiClient client) {
            this.client = client;
        }

        public async Task<IResult<List<UserDetail>>> GetAllAsync(string entity = null, bool? isActive = null, bool? populateEntityName = null, long? entityId = null) {
            var request = new Request("Security/Profiles", Method.GET);

            if (!string.IsNullOrEmpty(entity)) request.AddQueryParameter("entity", entity);
            if (isActive.HasValue) request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            if (populateEntityName.HasValue) request.AddQueryParameter("populateEntityName", populateEntityName.Value ? "1" : "0");
            if (entityId.HasValue) request.AddQueryParameter("entityId", entityId.Value.ToString());

            return await client.ExecuteTaskAsync<List<UserDetail>>(request);
        }

        public async Task<IResult<List<UserDetail>>> SearchAsync(string search, string entity = null, bool? isActive = default(bool?)) {
            var request = new Request("Security/Profiles/Search/{search}", Method.GET);
            request.AddUrlSegment("search", search);

            if (!string.IsNullOrEmpty(entity)) {
                request.AddQueryParameter("entity", entity);
            }

            if (isActive.HasValue) {
                request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            }

            return await client.ExecuteTaskAsync<List<UserDetail>>(request);
        }
    }
}