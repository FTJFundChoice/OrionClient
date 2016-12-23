using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class UserModule : IUserModule {
        private IRestClient client = null;

        public UserModule(IRestClient client) {
            this.client = client;
        }

        public async Task<IResult<User>> Create(User user) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Security/Users", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<User>(request);
            return new Result<User>(result);
        }

        public async Task<IResult<User>> Get(long id) {
            var request = new RestRequest("Security/Users/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = await client.ExecuteTaskAsync<User>(request);
            return new Result<User>(result);
        }

        public async Task<IResult<List<User>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestRequest("Security/Users", Method.GET);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = await client.ExecuteTaskAsync<List<User>>(request);
            return new Result<List<User>>(result);
        }

        public async Task<IResult<User>> Update(User user) {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("Security/Users/{id}", Method.PUT);
            request.AddUrlSegment("id", user.Id.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<User>(request);
            return new Result<User>(result);
        }
    }
}