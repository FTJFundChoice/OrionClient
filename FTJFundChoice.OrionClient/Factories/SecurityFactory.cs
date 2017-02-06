using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Factories {

    public class SecurityFactory : ISecurityFactory {
        private readonly Client client;

        public SecurityFactory(Client client) {
            this.client = client;
        }

        public IProfilesModule Profiles {
            get {
                return new ProfilesModule(client);
            }
        }

        public IUsersModule Users {
            get {
                return new UsersModule(client);
            }
        }

        public async Task<IResult<Token>> GetImpersonationToken(string entity, string entityId) {
            var request = new Request(Method.GET, AuthenticationHelpers.ImpersonationPath);
            request.AddHeader("Entity", entity);
            request.AddHeader("EntityId", entityId);

            return await client.ExecuteTaskAsync<Token>(request);
        }

        public async Task<IResult<Token>> GetToken(string username, string password) {
            var request = new Request(Method.GET, AuthenticationHelpers.AuthenticationPath);

            AuthenticationHelpers.ApplyBasicAuthentication(request, new Credentials {
                Username = username,
                Password = password
            });

            return await client.ExecuteTaskAsync<Token>(request);
        }
    }
}