using OrionClient.Helpers;
using OrionClient.Interfaces;
using OrionClient.Model;
using RestSharp;
using System.Collections.Generic;

namespace OrionClient.Compositions {

    public class UserModule : IUserModule {
        private IRestClient client = null;

        public UserModule(IRestClient client) {
            this.client = client;
        }

        public Result<User> Create(User user) {
            var request = new RestRequest("Security/Users", Method.POST);
            request.AddParameter("application/json", SimpleJson.SerializeObject(user, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<User>(request);
            return new Result<User>(result);
        }

        public Result<User> Get(long id) {
            var request = new RestRequest("Security/Users/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = client.Execute<User>(request);
            return new Result<User>(result);
        }

        public Result<List<User>> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestRequest("Security/Users", Method.GET);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = client.Execute<List<User>>(request);
            return new Result<List<User>>(result);
        }

        public Result<User> Update(User user) {
            var request = new RestRequest("Security/Users/{id}", Method.PUT);
            request.AddUrlSegment("id", user.Id.ToString());
            request.AddParameter("application/json", SimpleJson.SerializeObject(user, SimpleJson.DataContractJsonSerializerStrategy), ParameterType.RequestBody);

            var result = client.Execute<User>(request);
            return new Result<User>(result);
        }
    }
}