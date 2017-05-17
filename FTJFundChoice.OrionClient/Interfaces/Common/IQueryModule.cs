using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface IQueryModule<T> {

        Task<IResult<IEnumerable<T>>> GetAllAsync(int top = 10000, int skip = 0, bool? isActive = true);

        Task<IResult<T>> GetAsync(long id);
    }
}