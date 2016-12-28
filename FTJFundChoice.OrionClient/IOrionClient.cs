using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient {

    public interface IOrionClient {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
    }
}