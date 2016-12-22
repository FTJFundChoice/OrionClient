using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models;
using RestSharp;
using System;

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

        public Result<AuthToken> ImpersonationToken(string entity, string entityId) {
            var request = new RestRequest("Security/Token/Impersonate", Method.GET);
            request.AddHeader("entity", entity);
            request.AddHeader("entityId", entityId);

            var result = client.Execute<AuthToken>(request);
            return new Result<AuthToken>(result);
        }
    }
}