using System.Collections.Generic;

namespace OrionClient.Interfaces {

    public interface ICommon<T> {

        Result<List<T>> GetAll(int top = 1000, int skip = 0, bool? IsActive = null);

        Result<T> Get(long id);

        Result<T> Create(T representative);

        Result<T> Update(T representative);
    }
}