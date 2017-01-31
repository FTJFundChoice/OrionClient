using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Common {

    public interface IModifyModule<T> {

        Task<IResult<T>> Create(T entity);

        Task<IResult<T>> Update(T entity);

        Task<IResult> Delete(long id);

        Task<IResult> Delete(long[] id);
    }
}