using FTJFundChoice.OrionClient.Models.Trading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Trading
{
    public interface ISleeveStrategyModule
    {
        Task<IResult<List<SleeveStrategyVerbose>>> GetSleeveStrategyVerboseByRepIdAsync(int RepId);
        Task<IResult<List<SleeveStrategyVerbose>>> GetSleeveStrategyExpandedVerboseByRepIdAsync(int RepId);
    }
}
