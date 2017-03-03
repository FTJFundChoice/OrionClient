using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Interfaces.Trading;
using FTJFundChoice.OrionClient.Models.Trading;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Enums;

namespace FTJFundChoice.OrionClient.Compositions.Trading
{
    public class SleeveStrategyModule:ISleeveStrategyModule
    {
        private OrionApiClient client = null;

        public SleeveStrategyModule(OrionApiClient client)
        {
            this.client = client;
        }

        public async Task<IResult<List<SleeveStrategyVerbose>>> GetSleeveStrategyVerboseByRepIdAsync(int RepId)
        {
            var request = new Request("Trading/SleeveStrategy/Verbose?RepId={id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(RepId));
            return await client.ExecuteTaskAsync<List<SleeveStrategyVerbose>>(request);
        }
    }
}
