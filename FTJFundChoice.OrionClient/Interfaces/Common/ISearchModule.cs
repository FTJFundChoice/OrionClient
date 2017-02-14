using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface ISearchModule<T> {

        Task<IResult<List<T>>> SearchAsync(string search);
    }
}