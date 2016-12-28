using FTJFundChoice.OrionClient.Interfaces;
using RestSharp;

namespace FTJFundChoice.OrionClient.Factories {

    public class CompositionFactory : ICompositionFactory {
        private IRestClient client;

        public CompositionFactory(IRestClient client) {
            this.client = client;
        }

        public IPortfolioFactory Portfolio {
            get {
                return new PortfolioFactory(client);
            }
        }

        public ISecurityFactory Security {
            get {
                return new SecurityFactory(client);
            }
        }
    }
}