using OrionClient.Model;
using System.Collections.Generic;

namespace OrionClient.Interfaces {

    public interface IRepresentativeModule : ICommon<Representative> {

        IEnumerable<Representative> GetAll(int top = 1000, int skip = 0, bool? IsActive = false, bool includePorfolio = true, bool includeUserDefinedFields = false);

        Representative Get(long id, bool includePorfolio = true, bool includeUserDefinedFields = false);
    }
}