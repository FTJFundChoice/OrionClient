using FTJFundChoice.OrionClient.Interfaces.Accounts;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Interfaces.Clients;
using FTJFundChoice.OrionClient.Interfaces.Plans;
using FTJFundChoice.OrionClient.Interfaces.Representatives;
using FTJFundChoice.OrionClient.Interfaces.Settings;
using FTJFundChoice.OrionClient.Interfaces.SubAdvisors;
using FTJFundChoice.OrionClient.Interfaces.Trading;
using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ICompositionFactory {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
        ITradingFactory Trading { get; }
        ISettingsFactory Settings { get; }
    }

    public interface IPortfolioFactory {
		IAccountsModule Accounts { get; }
        IBrokerDealersModule BrokerDealers { get; }
        IRepresentativesModule Representatives { get; }
        IWholesalersModule Wholesalers { get; }
        IClientsModule Clients { get; }
        IPlanSponsorsModule PlanSponsors { get; }
		IPlansModule Plans { get; }
        IThirdPartyAdministratorsModule ThirdPartyAdministrators { get; }
        ISubAdvisorsModule SubAdvisors { get; }
    }

    public interface ISecurityFactory {
        IProfilesModule Profiles { get; }
        IUsersModule Users { get; }

        Task<IResult<Token>> GetImpersonationToken(string entity, string entityId);

        Task<IResult<Token>> GetToken(string username, string password);
    }

    public interface ITradingFactory
    {
        ISleeveStrategyModule SleeveStrategies { get; }

    }

    public interface ISettingsFactory
    {
        ISettingsModule CustomSettings { get; }
    }
}