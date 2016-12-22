using FTJFundChoice.OrionModels;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IProfileModule {

        Result<List<SearchProfile>> GetAll();

        Result<List<SearchProfile>> Search(string search, string entity = null, bool? isActive = null);
    }
}