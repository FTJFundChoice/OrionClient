using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient.Factories {

    public class CompositionFactory : ICompositionFactory {
        private readonly Client client;

        public CompositionFactory(Client client) {
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