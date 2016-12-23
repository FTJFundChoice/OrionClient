using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace FTJFundChoice.OrionClient {

    /// <summary>
    /// Custom OrionAuthenticator Basic\Token Authenticator.
    /// </summary>
    internal class OrionAuthenticator : IAuthenticator {
        private Credentials credentials = null;

        private Token authToken = null;

        public OrionAuthenticator(Credentials credentials) {
            this.credentials = credentials;
        }

        public void Authenticate(IRestClient client, IRestRequest request) {
            request.AddHeader("Accept", "application/json");

            if (!AuthenticationHelpers.IsAuthenticated(authToken))
                if (request.Resource != AuthenticationHelpers.AuthenticationPath)
                    authToken = AuthenticationHelpers.HandleBasicAuthentication(client, request, credentials);

            if (request.Resource == AuthenticationHelpers.ImpersonationPath)
                AuthenticationHelpers.HandleImpersonation(request, credentials);

            AuthenticationHelpers.ApplyTokenAuthentication(request, authToken);
        }
    }
}