using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;

namespace FTJFundChoice.OrionClient.Interfaces.BrokerDealers {

    public interface IBrokerDealersModule : IQueryModule<BrokerDealer> {
        IBrokerDealersVerboseModule Verbose { get; }
        IBrokerDealersSimpleModule Simple { get; }
    }
}