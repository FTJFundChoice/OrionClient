using System.Collections.Generic;

namespace OrionClient.Interfaces {

    public interface ICommon<T> {

        IEnumerable<T> GetAll(int top = 1000, int skip = 0, bool? IsActive = null);

        T Get(long id);

        T Create(T representative);

        T Update(T representative);
    }
}