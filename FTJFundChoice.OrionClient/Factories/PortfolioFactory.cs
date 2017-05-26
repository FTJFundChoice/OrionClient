using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Compositions.BrokerDealers;
using FTJFundChoice.OrionClient.Compositions.Clients;
using FTJFundChoice.OrionClient.Compositions.Representatives;
using FTJFundChoice.OrionClient.Compositions.SubAdvisors;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Interfaces.Accounts;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Interfaces.Clients;
using FTJFundChoice.OrionClient.Interfaces.Representatives;
using FTJFundChoice.OrionClient.Interfaces.SubAdvisors;

namespace FTJFundChoice.OrionClient.Factories {

    public class PortfolioFactory : IPortfolioFactory {
        private readonly OrionApiClient client;

        public PortfolioFactory(OrionApiClient client) {
            this.client = client;
        }

		public IAccountsModule Accounts
		{
			get
			{
				return new AccountsModule(client);
			}
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

        public IClientsModule Clients {
            get {
                return new ClientsModule(client);
            }
        }

        public IPlanSponsorsModule PlanSponsors {
            get {
                return new PlanSponsorsModule(client);
            }
        }

        public IThirdPartyAdministratorsModule ThirdPartyAdministrators {
            get {
                return new ThirdPartyAdministratorsModule(client);
            }
        }

        public ISubAdvisorsModule SubAdvisors {
            get {
                return new SubAdvisorsModule(client);
            }
        }
    }
}