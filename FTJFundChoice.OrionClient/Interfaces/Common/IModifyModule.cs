using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface IModifyModule<T> {

        Task<IResult<T>> CreateAsync(T entity);

        Task<IResult<T>> UpdateAsync(T entity);

        Task<IResult> DeleteAsync(long id);

        Task<IResult> DeleteAsync(long[] id);
    }
}