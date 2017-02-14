using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models.Security;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace FTJFundChoice.OrionClient.Compositions {

    public class UsersModule : IUsersModule {
        private OrionApiClient client = null;

        public UsersModule(OrionApiClient client) {
            this.client = client;
        }

        public async Task<IResult<List<long>>> ActivateAsync(bool isActive, List<long> ids) {
            var request = new Request("Security/Users/Action/Activate", Method.PUT);
            request.AddQueryParameter("activate", isActive.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(ids));
            return await client.ExecuteTaskAsync<List<long>>(request);
        }

        public async Task<IResult<UserInfoDetails>> CreateAsync(UserInfoDetails user) {
            return await CreateAsync(user, false);
        }

        public async Task<IResult<UserInfoDetails>> CreateAsync(UserInfoDetails user, bool sendEmail = false) {
            var request = new Request("Security/Users", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(user));
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public Task<IResult> DeleteAsync(long[] id) {
            throw new NotImplementedException();
        }

        public async Task<IResult> DeleteAsync(long userId) {
            var request = new Request("Security/Users/{id}", Method.DELETE);
            request.AddUrlSegment("id", userId.ToString());
            return await client.ExecuteTaskAsync<string>(request);
        }

        public async Task<IResult> Delete(UserInfoDetails user) {
            return await DeleteAsync(user.Id.Value);
        }

        public async Task<IResult<UserInfoDetails>> GetAsync(long id) {
            var request = new Request("Security/Users/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAll() {
            return await GetAllAsync(10000, 0, true, null);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = null) {
            return await GetAllAsync(top, skip, isActive, null);
        }

        public async Task<IResult<List<UserInfoDetails>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = null, string loginUserId = null) {
            var request = new Request("Security/Users", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            // Not Supported on API
            //request.AddActiveQueryParameters(isActive);

            if (!string.IsNullOrEmpty(loginUserId))
                request.AddQueryParameter("loginUserId", loginUserId);

            return await client.ExecuteTaskAsync<List<UserInfoDetails>>(request);
        }

        public async Task<IResult<UserInfoDetails>> ResetPasswordAsync(UserInfoDetails user, bool sendEmail = false, bool newUser = false) {
            return await ResetPasswordAsync(user.Id.Value, user.Password, sendEmail, newUser);
        }

        public async Task<IResult<UserInfoDetails>> ResetPasswordAsync(long userId, string password, bool sendEmail = false, bool newUser = false) {
            var request = new Request("Security/Users/{id}/Action/Password/Reset", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());
            request.AddQueryParameter("sendEmail", sendEmail.ToString());
            request.AddQueryParameter("newUser", newUser.ToString());
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<UserInfoDetails>> SetPasswordAsync(UserInfoDetails user) {
            return await SetPasswordAsync((long)user.Id, user.Password);
        }

        public async Task<IResult<UserInfoDetails>> SetPasswordAsync(long userId, string password) {
            var request = new Request("Security/Users/{id}/Action/Password/Set", Method.PUT);
            request.AddUrlSegment("id", userId.ToString());

            // Not documented by Orion
            var body = new SetPassword {
                NewPassword = password,
                IsReset = false
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(body));
            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }

        public async Task<IResult<UserInfoDetails>> UpdateAsync(UserInfoDetails user) {
            var request = new Request("Security/Users/{id}", Method.PUT);
            request.AddUrlSegment("id", user.Id.ToString());
            request.AddParameter("application/json", JsonConvert.SerializeObject(user));

            return await client.ExecuteTaskAsync<UserInfoDetails>(request);
        }
    }
}