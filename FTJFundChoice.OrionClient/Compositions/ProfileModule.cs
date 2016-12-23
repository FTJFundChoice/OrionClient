using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class ProfileModule : IProfileModule {
        private IRestClient client = null;

        public ProfileModule(IRestClient client) {
            this.client = client;
        }

        public async Task<IResult<List<SearchProfile>>> GetAll() {
            var request = new RestRequest("Security/Profiles", Method.GET);

            var result = await client.ExecuteTaskAsync<List<SearchProfile>>(request);
            return new Result<List<SearchProfile>>(result);
        }

        public async Task<IResult<List<SearchProfile>>> Search(string search, string entity = null, bool? isActive = default(bool?)) {
            var request = new RestRequest("Security/Profiles/Search/{search}", Method.GET);
            request.AddUrlSegment("search", search);

            if (!string.IsNullOrEmpty(entity)) {
                request.AddQueryParameter("entity", entity);
            }

            if (isActive.HasValue) {
                request.AddQueryParameter("isActive", isActive.Value ? "1" : "0");
            }

            var result = await client.ExecuteTaskAsync<List<SearchProfile>>(request);
            return new Result<List<SearchProfile>>(result);
        }
    }
}