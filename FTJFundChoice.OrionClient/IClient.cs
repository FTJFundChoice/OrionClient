using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient {

    public interface IClient {
        IPortfolioFactory Portfolio { get; }
        ISecurityFactory Security { get; }
    }
}