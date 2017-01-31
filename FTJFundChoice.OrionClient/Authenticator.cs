using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient {

    /// <summary>
    /// Custom OrionAuthenticator Basic\Token Authenticator.
    /// </summary>
    internal class Authenticator {
        private readonly Credentials credentials = null;
        private Token authToken = null;

        public Authenticator(Credentials credentials) {
            this.credentials = credentials;
        }

        public async Task AuthenticateAsync(Client client, Request request) {
            if (!AuthenticationHelpers.IsAuthenticated(authToken))
                if (request.RequestUri.ToString() != AuthenticationHelpers.AuthenticationPath)
                    authToken = await AuthenticationHelpers.HandleBasicAuthenticationAsync(client, request, credentials);

            if (request.RequestUri.ToString() == AuthenticationHelpers.ImpersonationPath)
                AuthenticationHelpers.HandleImpersonation(request, credentials);

            AuthenticationHelpers.ApplyTokenAuthentication(request, authToken);
        }
    }
}