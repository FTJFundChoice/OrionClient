using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models;
using RestSharp;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Factories {

    public class SecurityFactory : ISecurityFactory {
        private IRestClient client;

        public SecurityFactory(IRestClient client) {
            this.client = client;
        }

        public IProfileModule Profiles {
            get {
                return new ProfileModule(client);
            }
        }

        public IUserModule Users {
            get {
                return new UserModule(client);
            }
        }

        public async Task<IResult<Token>> GetImpersonationToken(string entity, string entityId) {
            var request = new OrionRequest(AuthenticationHelpers.ImpersonationPath, Method.GET);
            request.AddHeader("entity", entity);
            request.AddHeader("entityId", entityId);

            var result = await client.ExecuteGetTaskAsync<Token>(request);
            return new Result<Token>(result);
        }

        public async Task<IResult<Token>> GetToken(string username, string password) {
            var request = new OrionRequest(AuthenticationHelpers.AuthenticationPath, Method.GET);

            AuthenticationHelpers.ApplyBasicAuthentication(request, new Credentials {
                Username = username,
                Password = password
            });

            var result = await client.ExecuteGetTaskAsync<Token>(request);
            return new Result<Token>(result);
        }
    }
}