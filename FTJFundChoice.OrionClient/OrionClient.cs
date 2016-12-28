using FTJFundChoice.OrionClient.Factories;
using FTJFundChoice.OrionClient.Interfaces;
using RestSharp;

namespace FTJFundChoice.OrionClient {

    public class OrionClient : IOrionClient {
        private IRestClient client = null;
        private ICompositionFactory factory = null;

        public OrionClient(string baseUrl, Credentials apiCredentials) {
            client = new RestClient(baseUrl);
            client.Authenticator = new OrionAuthenticator(apiCredentials);
            client.ClearHandlers();

            client.AddHandler("application/json", OrionJsonSerializer.Default);
            client.AddHandler("text/json", OrionJsonSerializer.Default);
            client.AddHandler("text/x-json", OrionJsonSerializer.Default);
            client.AddHandler("text/javascript", OrionJsonSerializer.Default);
            client.AddHandler("*+json", OrionJsonSerializer.Default);

            // ICompositionFactory is the only singleton, by design.
            factory = new CompositionFactory(client);
        }

        public IPortfolioFactory Portfolio {
            get {
                return factory.Portfolio;
            }
        }

        public ISecurityFactory Security {
            get {
                return factory.Security;
            }
        }
    }
}