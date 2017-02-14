using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Interfaces.Clients;
using FTJFundChoice.OrionClient.Interfaces.Representatives;
using FTJFundChoice.OrionClient.Interfaces.SubAdvisors;
using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ICompositionFactory {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
    }

    public interface IPortfolioFactory {
        IBrokerDealersModule BrokerDealers { get; }
        IRepresentativesModule Representatives { get; }
        IWholesalersModule Wholesalers { get; }
        IClientsModule Clients { get; }
        IPlanSponsorsModule PlanSponsors { get; }
        IThirdPartyAdministratorsModule ThirdPartyAdministrators { get; }
        ISubAdvisorsModule SubAdvisors { get; }
    }

    public interface ISecurityFactory {
        IProfilesModule Profiles { get; }
        IUsersModule Users { get; }

        Task<IResult<Token>> GetImpersonationToken(string entity, string entityId);

        Task<IResult<Token>> GetToken(string username, string password);
    }
}