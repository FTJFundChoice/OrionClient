using RestSharp;
using RestSharp.Authenticators;
using System;

namespace OrionClient {

    /// <summary>
    /// Custom OrionAuthenticator Basic\Token Authenticator.
    /// </summary>
    internal class OrionAuthenticator : IAuthenticator {
        private string username = null;
        private string password = null;
        private string authPath = "/security/token";

        public OrionAuthenticator(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public void Authenticate(IRestClient client, IRestRequest request) {
            if (!IsAuthenticated(client)) {
                if (request.Resource != authPath) {
                    SetBasicAuthentication(client, request);
                }
            }
        }

        private void SetBasicAuthentication(IRestClient client, IRestRequest request) {
            var authRequest = new RestRequest(authPath, Method.GET);
            authRequest.AddHeader("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password))));
        }

        private bool IsAuthenticated(IRestClient client) {
            return false;
        }
    }
}