using FTJFundChoice.OrionClient.Interfaces;

namespace FTJFundChoice.OrionClient {

    public interface IOrionClient {
        IPortfolioModule Portfolio { get; }
        ISecurityModule Security { get; }
    }
}