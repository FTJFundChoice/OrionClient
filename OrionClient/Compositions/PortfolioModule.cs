using OrionClient.Interfaces;
using RestSharp;

namespace OrionClient.Compositions {

    internal class PortfolioModule : IPortfolioModule {
        private IBrokerDealerModule brokerDealer = null;
        private IRepresentativeModule representative = null;
        private IWholesalerModule wholesaler = null;

        public PortfolioModule(IRestClient client) {
            brokerDealer = new BrokerDealerModule(client);
            representative = new RepresentativeModule(client);
            wholesaler = new WholesalerModule(client);
        }

        public IBrokerDealerModule BrokerDealers {
            get {
                return brokerDealer;
            }
        }

        public IRepresentativeModule Representatives {
            get {
                return representative;
            }
        }

        public IWholesalerModule Wholesalers {
            get {
                return wholesaler;
            }
        }
    }
}