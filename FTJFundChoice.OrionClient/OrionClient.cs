using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Interfaces;
using RestSharp;

namespace FTJFundChoice.OrionClient {

    public class OrionClient : IOrionClient {
        private IRestClient client = null;
        private IPortfolioModule portfolioModule;
        private ISecurityModule securityModule;

        public OrionClient(string baseUrl, Credentials apiCredentials) {
            client = new RestClient(baseUrl);
            client.Authenticator = new OrionAuthenticator(apiCredentials);

            portfolioModule = new PortfolioModule(client);
            securityModule = new SecurityModule(client);
        }

        public IPortfolioModule Portfolio {
            get {
                return portfolioModule;
            }
        }

        public ISecurityModule Security {
            get {
                return securityModule;
            }
        }
    }
}