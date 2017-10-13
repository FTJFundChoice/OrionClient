using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Enums;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Representatives {

    public interface IRepresentativesVerboseModule : IModifyModule<RepresentativeVerbose>, IQueryModule<RepresentativeVerbose> {

        Task<IResult<IEnumerable<RepresentativeVerbose>>> GetAllAsync(int top = 5000, int skip = 0, bool? IsActive = false, params RepresentativeExpands[] expands);

		Task<IResult<IEnumerable<RepresentativeVerbose>>> GetAllAsync(params RepresentativeExpands[] expands);

		Task<IResult<RepresentativeVerbose>> GetAsync(long id, params RepresentativeExpands[] expands);
    }
}