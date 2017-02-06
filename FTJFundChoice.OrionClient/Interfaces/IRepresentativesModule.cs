using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IRepresentativesModule : IModifyModule<RepresentativeVerbose>, IQueryModule<RepresentativeVerbose> {

        Task<IResult<List<RepresentativeVerbose>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Task<IResult<RepresentativeVerbose>> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}