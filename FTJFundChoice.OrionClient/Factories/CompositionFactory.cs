using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient.Factories {

    public class CompositionFactory : ICompositionFactory {
        private readonly OrionApiClient client;

        public CompositionFactory(OrionApiClient client) {
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

        public ITradingFactory Trading
        {
            get
            {
                return new TradingFactory(client);
            }
        }
    }
}