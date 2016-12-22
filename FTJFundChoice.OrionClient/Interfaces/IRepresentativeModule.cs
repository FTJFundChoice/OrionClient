using FTJFundChoice.OrionClient.Models;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IRepresentativeModule : ICommonModify<Representative>, ICommonRead<Representative> {

        Result<List<Representative>> GetAll(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Result<Representative> Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}