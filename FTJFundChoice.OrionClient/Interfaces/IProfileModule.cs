using FTJFundChoice.OrionModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IProfileModule {

        Task<IResult<List<SearchProfile>>> GetAll();

        Task<IResult<List<SearchProfile>>> Search(string search, string entity = null, bool? isActive = null);
    }
}