using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient {

    public interface IOrionApiClient {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
        ITradingFactory Trading { get; }
    }
}