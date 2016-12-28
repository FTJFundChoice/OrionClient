using FTJFundChoice.OrionModels;
using FTJFundChoice.OrionModels.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IRepresentativeModule : ICommonModify<Representative>, ICommonRead<Representative> {

        Task<IResult<List<Representative>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Task<IResult<Representative>> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}