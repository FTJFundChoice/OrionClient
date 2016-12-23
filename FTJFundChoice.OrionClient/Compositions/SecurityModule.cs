using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class SecurityModule : ISecurityModule {
        private IRestClient client;
        private IUserModule userModule;
        private IProfileModule profileModule;

        public SecurityModule(IRestClient client) {
            this.client = client;
            userModule = new UserModule(client);
            profileModule = new ProfileModule(client);
        }

        public IUserModule Users {
            get {
                return userModule;
            }
        }

        public IProfileModule Profiles {
            get {
                return profileModule;
            }
        }

        public async Task<IResult<Token>> GetImpersonationToken(string entity, string entityId) {
            var request = new RestRequest(AuthenticationHelpers.ImpersonationPath, Method.GET);
            request.AddHeader("entity", entity);
            request.AddHeader("entityId", entityId);

            var result = await client.ExecuteGetTaskAsync<Token>(request);
            return new Result<Token>(result);
        }

        public async Task<IResult<Token>> GetToken(string username, string password) {
            var request = new RestRequest(AuthenticationHelpers.AuthenticationPath, Method.GET);

            AuthenticationHelpers.ApplyBasicAuthentication(request, new Credentials {
                Username = username,
                Password = password
            });

            var result = await client.ExecuteGetTaskAsync<Token>(request);
            return new Result<Token>(result);
        }
    }
}