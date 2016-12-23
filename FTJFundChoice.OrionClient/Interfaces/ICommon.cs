using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ICommonRead<T> {

        Task<IResult<List<T>>> GetAll(int top = 1000, int skip = 0, bool? IsActive = null);

        Task<IResult<T>> Get(long id);
    }

    public interface ICommonModify<T> {

        Task<IResult<T>> Create(T entity);

        Task<IResult<T>> Update(T entity);
    }
}