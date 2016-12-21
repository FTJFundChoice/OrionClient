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
        private string username = null;
        private string password = null;
        private string authPath = "security/token";

        private string token = null;
        private DateTime? tokenExpirationDate = null;

        public OrionAuthenticator(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public void Authenticate(IRestClient client, IRestRequest request) {
            if (!IsAuthenticated(client)) {
                if (request.Resource != authPath) {
                    string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password)));
                    var authHeader = string.Format("Basic {0}", authToken);
                    var authRequest = new RestRequest(authPath, Method.GET);
                    authRequest.AddParameter("Authorization", authHeader, ParameterType.HttpHeader); request.AddHeader("Accept", "application/json");
                    authRequest.AddHeader("Accept", "application/json");
                    var response = client.Execute(authRequest);

                    if (response.StatusCode != System.Net.HttpStatusCode.OK) {
                        throw new Exception("Unable to obtain Orion API token.");
                    }

                    dynamic result = SimpleJson.DeserializeObject<dynamic>(response.Content);
                    token = result.access_token;
                    tokenExpirationDate = DateTime.Now.AddMilliseconds(result.expires_in);
                }
            }

            if (!request.Parameters.Any(p => p.Name.Equals("Authorization", StringComparison.OrdinalIgnoreCase))) {
                var authHeader = string.Format("Session {0}", token);
                request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
            }
        }

        private bool IsAuthenticated(IRestClient client) {
            if (string.IsNullOrEmpty(token) ||              // empty token
                !tokenExpirationDate.HasValue ||            // empty expiration date
                tokenExpirationDate < DateTime.Now) {       // invalid expiration date
                return false;
            }
            return true;
        }
    }
}