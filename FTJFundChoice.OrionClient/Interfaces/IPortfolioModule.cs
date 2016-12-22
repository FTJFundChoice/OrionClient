namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IPortfolioModule {
        IRepresentativeModule Representatives { get; }
        IBrokerDealerModule BrokerDealers { get; }
        IWholesalerModule Wholesalers { get; }
    }
}