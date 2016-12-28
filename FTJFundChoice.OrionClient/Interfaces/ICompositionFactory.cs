using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ICompositionFactory {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
    }

    public interface IPortfolioFactory {
        IBrokerDealerModule BrokerDealers { get; }
        IRepresentativeModule Representatives { get; }
        IWholesalerModule Wholesalers { get; }
    }

    public interface ISecurityFactory {
        IProfileModule Profiles { get; }
        IUserModule Users { get; }

        Task<IResult<Token>> GetImpersonationToken(string entity, string entityId);

        Task<IResult<Token>> GetToken(string username, string password);
    }
}