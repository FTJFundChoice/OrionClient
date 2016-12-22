using OrionClient.Interfaces;
using RestSharp;
using System;

namespace OrionClient.Compositions {

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

        public Result ImpersonationToken(string entity, string entityId) {
            var request = new RestRequest("Security/Token/Impersonate", Method.GET);
            request.AddHeader("entity", entity);
            request.AddHeader("entityId", entityId);

            var result = client.Execute(request);
            return new Result(result);
        }
    }
}