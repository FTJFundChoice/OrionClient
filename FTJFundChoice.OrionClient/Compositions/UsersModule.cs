using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels.Security;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class UsersModule : IUsersModule {
        private Client client = null;

        public UsersModule(Client client) {
            this.client = client;
        }

        public async Task<IResult<List<long>>> Activate(bool isActive, List<long> ids) {
            var request = new Request("/Security/Users/Action/Activate", Method.PUT);
            request.AddQueryParameter("activate", isActive.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(ids));
            return await client.ExecuteTaskAsync<List<long>>(request);
        }

        public async Task<IResult<UserInfoDetails>> Create(UserInfoDetails user) {
            return await Create(user, false);
        }

        public async Task<IResult<UserInfoDetails>> Create(UserInfoDetails user, bool sendEmail = false) {
            var request = new Request("Security/Users", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(user));
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult> Delete(long userId) {
            var request = new Request("Security/Users/{id}", Method.DELETE);
            request.AddUrlSegment("id", userId.ToString());
            return await client.ExecuteTaskAsync<string>(request);
        }

        public async Task<IResult> Delete(UserInfoDetails user) {
            return await Delete(user.Id.Value);
        }

        public async Task<IResult<UserInfoDetails>> Get(long id) {
            var request = new Request("Security/Users/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAll() {
            return await GetAll(1000, 0, false, null);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAll(int top = 100, int skip = 0, bool? isActive = null, string loginUserId = null) {
            var request = new Request("Security/Users", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);

            if (!string.IsNullOrEmpty(loginUserId))
                request.AddQueryParameter("loginUserId", loginUserId);

            return await client.ExecuteTaskAsync<List<UserInfoDetails>>(request);
        }

        public async Task<IResult<UserInfoDetails>> ResetPassword(UserInfoDetails user, bool sendEmail = false, bool newUser = false) {
            return await ResetPassword(user.Id.Value, user.Password, sendEmail, newUser);
        }

        public async Task<IResult<UserInfoDetails>> ResetPassword(long userId, string password, bool sendEmail = false, bool newUser = false) {
            var request = new Request("/Security/Users/{id}/Action/Password/Reset", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            request.AddQueryParameter("newUser", newUser.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<UserInfoDetails>> SetPassword(UserInfoDetails user) {
            return await SetPassword((long)user.Id, user.Password);
        }

        public async Task<IResult<UserInfoDetails>> SetPassword(long userId, string password) {
            var request = new Request("/Security/Users/{id}/Action/Password/Set", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());

            // Not documented by Orion
            dynamic setPasswordBody = new {
                newPassword = password,
                isReset = false
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(setPasswordBody));

            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<UserInfoDetails>> Update(UserInfoDetails user) {
            var request = new Request("Security/Users/{id}", Method.PUT);
            request.AddUrlSegment("id", user.Id.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(user));

            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }
    }
}