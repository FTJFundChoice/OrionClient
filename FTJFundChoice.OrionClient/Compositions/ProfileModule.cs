using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels.Security;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class ProfileModule : IProfileModule {
        private IRestClient client = null;

        public ProfileModule(IRestClient client) {
            this.client = client;
        }

        public async Task<IResult<List<UserDetail>>> GetAll(string entity = null, bool? isActive = null, bool? populateEntityName = null, long? entityId = null) {
            var request = new OrionRequest("Security/Profiles", Method.GET);

            if (!string.IsNullOrEmpty(entity)) request.AddQueryParameter("entity", entity);
            if (isActive.HasValue) request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            if (populateEntityName.HasValue) request.AddQueryParameter("populateEntityName", populateEntityName.Value ? "1" : "0");
            if (entityId.HasValue) request.AddQueryParameter("entityId", entityId.Value.ToString());

            var result = await client.ExecuteTaskAsync<List<UserDetail>>(request);
            return new Result<List<UserDetail>>(result);
        }

        public async Task<IResult<List<UserDetail>>> Search(string search, string entity = null, bool? isActive = default(bool?)) {
            var request = new OrionRequest("Security/Profiles/Search/{search}", Method.GET);
            request.AddUrlSegment("search", search);

            if (!string.IsNullOrEmpty(entity)) {
                request.AddQueryParameter("entity", entity);
            }

            if (isActive.HasValue) {
                request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            }

            var result = await client.ExecuteTaskAsync<List<UserDetail>>(request);
            return new Result<List<UserDetail>>(result);
        }
    }
}