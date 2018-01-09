using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Helpers {

    internal static class AuthenticationHelpers {
        internal static string AuthenticationPath = "Security/Token";
        internal static string ImpersonationPath = "Security/Token/Impersonate";

        internal static bool IsAuthenticated(Token authToken) {
            if (authToken == null || authToken.ExpirationDate < DateTime.Now) {
                return false;
            }
            return true;
        }

        internal static Token HandleBasicAuthentication(OrionApiClient OrionClient, Request request, Credentials credentials)
        {
            var authRequest = new Request(Method.GET, AuthenticationPath);
            ApplyBasicAuthentication(authRequest, credentials);

            var response = OrionClient.ExecuteTask<Token>(authRequest);
            if (response.StatusCode != StatusCode.OK)
            {
                throw new Exception("Unable to obtain Orion API token.");
            }
            return response.Data;
        }

        internal static async Task<Token> HandleBasicAuthenticationAsync(OrionApiClient OrionClient, Request request, Credentials credentials) {
            var authRequest = new Request(Method.GET, AuthenticationPath);
            ApplyBasicAuthentication(authRequest, credentials);

            var response = await OrionClient.ExecuteTaskAsync<Token>(authRequest);
            if (response.StatusCode != StatusCode.OK) {
                throw new Exception("Unable to obtain Orion API token.");
            }
            return response.Data;
        }

        internal static void HandleImpersonation(Request request, Token token) {
            if (request.RequestUri.ToString() == ImpersonationPath) {
                ApplyImpersonationAuthentication(request, token);
                // reroute to /Security/Token
                request.RequestUri = new Uri(AuthenticationPath, UriKind.Relative);
            }
        }

        internal static void ApplyImpersonationAuthentication(Request request, Token token) {
            var authHeader = string.Format("Impersonate {0}", token.AccessToken);
            request.Headers.Add("Authorization", authHeader);
        }

        internal static void ApplyBasicAuthentication(Request request, Credentials credentials) {
            string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}",
                credentials.Username,
                credentials.Password
            )));
            var authHeader = string.Format("Basic {0}", authToken);
            request.Headers.Add("Authorization", authHeader);
        }

        internal static void ApplyTokenAuthentication(Request request, Token authToken) {
            if (!request.Headers.Any(p => p.Key.Equals("Authorization", StringComparison.OrdinalIgnoreCase))) {
                var authHeader = string.Format("Session {0}", authToken.AccessToken);
                request.Headers.Add("Authorization", authHeader);
            }
        }
    }
}