using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Representatives {

    public interface IRepresentativesVerboseModule : IModifyModule<RepresentativeVerbose>, IQueryModule<RepresentativeVerbose> {

        Task<IResult<IEnumerable<RepresentativeVerbose>>> GetAllAsync(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Task<IResult<RepresentativeVerbose>> GetAsync(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}