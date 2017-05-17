using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.BrokerDealers {

    public interface IBrokerDealersVerboseModule : IModifyModule<BrokerDealerVerbose>, IQueryModule<BrokerDealerVerbose> {

        Task<IResult<IEnumerable<BrokerDealerVerbose>>> GetAllAsync(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Task<IResult<BrokerDealerVerbose>> GetAsync(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}