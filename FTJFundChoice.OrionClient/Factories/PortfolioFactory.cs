using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;

namespace FTJFundChoice.OrionClient.Factories {

    public class PortfolioFactory : IPortfolioFactory {
        private readonly Client client;

        public PortfolioFactory(Client client) {
            this.client = client;
        }

        public IBrokerDealersModule BrokerDealers {
            get {
                return new BrokerDealersModule(client);
            }
        }

        public IRepresentativesModule Representatives {
            get {
                return new RepresentativesModule(client);
            }
        }

        public IWholesalersModule Wholesalers {
            get {
                return new WholesalersModule(client);
            }
        }
    }
}