using FTJFundChoice.OrionClient.Compositions.Trading;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Helpers;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Interfaces.Trading;
using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;



namespace FTJFundChoice.OrionClient.Factories
{
    public class TradingFactory: ITradingFactory
    {
        private readonly OrionApiClient client;

        public TradingFactory(OrionApiClient client)
        {
            this.client = client;
        }

        public ISleeveStrategyModule SleeveStrategies
        {
            get
            {
                return new SleeveStrategyModule(client);
            }
        }
    }
}
