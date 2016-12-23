using FTJFundChoice.OrionClient.Models;
using RestSharp;
using System;
using System.Linq;
using System.Text;

namespace FTJFundChoice.OrionClient.Helpers {

    public static class AuthenticationHelpers {
        public static string AuthenticationPath = "Security/Token";
        public static string ImpersonationPath = "Security/Token/Impersonate";

        public static bool IsAuthenticated(Token authToken) {
            if (authToken == null || authToken.ExpirationDate < DateTime.Now) {
                return false;
            }
            return true;
        }

        public static Token HandleBasicAuthentication(IRestClient client, IRestRequest request, Credentials credentials) {
            var authRequest = new RestRequest(AuthenticationPath, Method.GET);
            ApplyBasicAuthentication(authRequest, credentials);

            var response = client.Execute<Token>(authRequest);
            if (response.StatusCode != System.Net.HttpStatusCode.OK) {
                throw new Exception("Unable to obtain Orion API token.");
            }
            return response.Data;
        }

        public static void HandleImpersonation(IRestRequest request, Credentials credentials) {
            if (request.Resource == ImpersonationPath) {
                ApplyBasicAuthentication(request, credentials);
                // reroute to /Security/Token
                request.Resource = AuthenticationPath;
            }
        }

        public static void ApplyBasicAuthentication(IRestRequest request, Credentials credentials) {
            string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}",
                credentials.Username,
                credentials.Password
            )));
            var authHeader = string.Format("Basic {0}", authToken);
            request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
        }

        public static void ApplyTokenAuthentication(IRestRequest request, Token authToken) {
            if (!request.Parameters.Any(p => p.Name.Equals("Authorization", StringComparison.OrdinalIgnoreCase))) {
                var authHeader = string.Format("Session {0}", authToken.AccessToken);
                request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
            }
        }
    }
}