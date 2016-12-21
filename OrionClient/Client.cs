using OrionClient.Compositions;
using OrionClient.Interfaces;
using RestSharp;

namespace OrionClient {

    public class Client {
        private IRestClient client = null;
        private IPortfolioModule _portfolioModule;

        public Client(string baseUrl, string username, string password) {
            client = new RestClient(baseUrl);
            client.Authenticator = new OrionAuthenticator(username, password);

            _portfolioModule = new PortfolioModule(client);
        }

        public IPortfolioModule Portfolio {
            get {
                return _portfolioModule;
            }
        }
    }
}