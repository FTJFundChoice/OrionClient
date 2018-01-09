using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient {

    /// <summary>
    /// Custom OrionAuthenticator Basic\Token Authenticator.
    /// </summary>
    internal class Authenticator {
        private readonly Credentials apiCredentials = null;
        private readonly Credentials serviceCredentials = null;
        private Token authToken = null;
        private Token impToken = null;

        public Authenticator(Credentials apiCredentials, Credentials serviceCredentials) {
            this.apiCredentials = apiCredentials;
            this.serviceCredentials = serviceCredentials;
        }
        public void Authenticate(OrionApiClient client, Request request)
        {
            if (!AuthenticationHelpers.IsAuthenticated(authToken))
                if (request.RequestUri.ToString() != AuthenticationHelpers.AuthenticationPath &&
                    request.RequestUri.ToString() != AuthenticationHelpers.ImpersonationPath)
                    authToken = AuthenticationHelpers.HandleBasicAuthentication(client, request, apiCredentials);

            if (request.RequestUri.ToString() == AuthenticationHelpers.ImpersonationPath)
            {
                impToken = AuthenticationHelpers.HandleBasicAuthentication(client, request, serviceCredentials);
                AuthenticationHelpers.HandleImpersonation(request, impToken);
            }
            else
                AuthenticationHelpers.ApplyTokenAuthentication(request, authToken);
        }

        public async Task AuthenticateAsync(OrionApiClient client, Request request) {
            if (!AuthenticationHelpers.IsAuthenticated(authToken))
                if (request.RequestUri.ToString() != AuthenticationHelpers.AuthenticationPath &&
                    request.RequestUri.ToString() != AuthenticationHelpers.ImpersonationPath)
                    authToken = await AuthenticationHelpers.HandleBasicAuthenticationAsync(client, request, apiCredentials);

            if (request.RequestUri.ToString() == AuthenticationHelpers.ImpersonationPath) {
                impToken = await AuthenticationHelpers.HandleBasicAuthenticationAsync(client, request, serviceCredentials);
                AuthenticationHelpers.HandleImpersonation(request, impToken);
            }
            else
                AuthenticationHelpers.ApplyTokenAuthentication(request, authToken);
        }
    }
}