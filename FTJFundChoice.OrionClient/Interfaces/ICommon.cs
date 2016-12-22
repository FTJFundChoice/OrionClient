using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ICommonRead<T> {

        Result<List<T>> GetAll(int top = 1000, int skip = 0, bool? IsActive = null);

        Result<T> Get(long id);
    }

    public interface ICommonModify<T> {

        Result<T> Create(T entity);

        Result<T> Update(T entity);
    }
}