using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Interfaces;
using RestSharp;

namespace FTJFundChoice.OrionClient.Factories {

    public class PortfolioFactory : IPortfolioFactory {
        private IRestClient client;

        public PortfolioFactory(IRestClient client) {
            this.client = client;
        }

        public IBrokerDealerModule BrokerDealers {
            get {
                return new BrokerDealerModule(client);
            }
        }

        public IRepresentativeModule Representatives {
            get {
                return new RepresentativeModule(client);
            }
        }

        public IWholesalerModule Wholesalers {
            get {
                return new WholesalerModule(client);
            }
        }
    }
}