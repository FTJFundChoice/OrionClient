using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels.Security;
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

        public async Task<IResult<List<long>>> Activate(bool isActive, List<long> ids) {
            var request = new OrionRequest("/Security/Users/Action/Activate", Method.PUT);
            request.AddQueryParameter("activate", isActive.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(ids), ParameterType.RequestBody);
            var result = await client.ExecuteTaskAsync<List<long>>(request);
            return new Result<List<long>>(result);
        }

        public async Task<IResult<UserInfoDetails>> Create(UserInfoDetails user) {
            return await Create(user, false);
        }

        public async Task<IResult<UserInfoDetails>> Create(UserInfoDetails user, bool sendEmail = false) {
            var request = new OrionRequest("Security/Users", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            var result = await client.ExecuteTaskAsync<UserInfoDetails>(request);
            return new Result<UserInfoDetails>(result);
        }

        public async Task<IResult> Delete(long userId) {
            var request = new OrionRequest("Security/Users/{id}", Method.DELETE);
            request.AddUrlSegment("id", userId.ToString());
            var result = await client.ExecuteTaskAsync(request);
            return new Result(result);
        }

        public async Task<IResult> Delete(UserInfoDetails user) {
            return await Delete(user.Id.Value);
        }

        public async Task<IResult<UserInfoDetails>> Get(long id) {
            var request = new OrionRequest("Security/Users/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = await client.ExecuteTaskAsync<UserInfoDetails>(request);
            return new Result<UserInfoDetails>(result);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAll() {
            var request = new OrionRequest("Security/Users", Method.GET);

            var result = await client.ExecuteTaskAsync<List<UserInfoDetails>>(request);
            return new Result<List<UserInfoDetails>>(result);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAll(bool? isActive = default(bool?), string loginUserId = null) {
            var request = new OrionRequest("Security/Users", Method.GET);
            request.AddActiveQueryParameters(isActive);

            if (!string.IsNullOrEmpty(loginUserId))
                request.AddQueryParameter("loginUserId", loginUserId);

            var result = await client.ExecuteTaskAsync<List<UserInfoDetails>>(request);
            return new Result<List<UserInfoDetails>>(result);
        }

        public async Task<IResult<UserInfoDetails>> ResetPassword(UserInfoDetails user, bool sendEmail = false, bool newUser = false) {
            return await ResetPassword(user.Id.Value, user.Password, sendEmail, newUser);
        }

        public async Task<IResult<UserInfoDetails>> ResetPassword(long userId, string password, bool sendEmail = false, bool newUser = false) {
            var request = new OrionRequest("/Security/Users/{id}/Action/Password/Reset", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            request.AddQueryParameter("newUser", newUser.ToString());
            var result = await client.ExecuteTaskAsync<UserInfoDetails>(request);
            return new Result<UserInfoDetails>(result);
        }

        public async Task<IResult<UserInfoDetails>> SetPassword(UserInfoDetails user) {
            return await SetPassword((long)user.Id, user.Password);
        }

        public async Task<IResult<UserInfoDetails>> SetPassword(long userId, string password) {
            var request = new OrionRequest("/Security/Users/{id}/Action/Password/Set", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());

            // Not documented by Orion
            dynamic setPasswordBody = new {
                newPassword = password,
                isReset = false
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(setPasswordBody), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<UserInfoDetails>(request);
            return new Result<UserInfoDetails>(result);
        }

        public async Task<IResult<UserInfoDetails>> Update(UserInfoDetails user) {
            var request = new OrionRequest("Security/Users/{id}", Method.PUT);
            request.AddUrlSegment("id", user.Id.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(user), ParameterType.RequestBody);

            var result = await client.ExecuteTaskAsync<UserInfoDetails>(request);
            return new Result<UserInfoDetails>(result);
        }
    }
}