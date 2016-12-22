using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Linq;
using System.Text;

namespace OrionClient {

    /// <summary>
    /// Custom OrionAuthenticator Basic\Token Authenticator.
    /// </summary>
    internal class OrionAuthenticator : IAuthenticator {
        private Credentials apiCredentials = null;
        private string authPath = "Security/Token";
        private string impersonationPath = "Security/Token/Impersonate";

        private string token = null;
        private DateTime? tokenExpirationDate = null;

        public OrionAuthenticator(Credentials apiCredentials) {
            this.apiCredentials = apiCredentials;
        }

        public void Authenticate(IRestClient client, IRestRequest request) {
            HandleAuthentication(client, request);
            HandleImpersonation(request);
            ApplyTokenAuthentication(request);
        }

        private void HandleAuthentication(IRestClient client, IRestRequest request) {
            if (!IsAuthenticated()) {
                if (request.Resource != authPath) {
                    var authRequest = new RestRequest(authPath, Method.GET);
                    ApplyBasicAuthentication(authRequest);

                    var response = client.Execute(authRequest);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK) {
                        throw new Exception("Unable to obtain Orion API token.");
                    }

                    dynamic result = SimpleJson.DeserializeObject<dynamic>(response.Content);
                    token = result.access_token;
                    tokenExpirationDate = DateTime.Now.AddMilliseconds(result.expires_in);
                }
            }
        }

        private void HandleImpersonation(IRestRequest request) {
            if (request.Resource == impersonationPath) {
                ApplyBasicAuthentication(request);
                // reroute to /Security/Token
                request.Resource = authPath;
            }
        }

        private void ApplyBasicAuthentication(IRestRequest request) {
            string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}",
                apiCredentials.Username,
                apiCredentials.Password
            )));
            var authHeader = string.Format("Basic {0}", authToken);
            request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
            request.AddHeader("Accept", "application/json");
        }

        private void ApplyTokenAuthentication(IRestRequest request) {
            if (!request.Parameters.Any(p => p.Name.Equals("Authorization", StringComparison.OrdinalIgnoreCase))) {
                var authHeader = string.Format("Session {0}", token);
                request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
            }
        }

        private bool IsAuthenticated() {
            if (string.IsNullOrEmpty(token) ||              // empty token
                !tokenExpirationDate.HasValue ||            // empty expiration date
                tokenExpirationDate < DateTime.Now) {       // invalid expiration date
                return false;
            }
            return true;
        }
    }
}