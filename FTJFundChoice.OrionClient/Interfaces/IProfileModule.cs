using FTJFundChoice.OrionModels.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IProfileModule {

        Task<IResult<List<UserDetail>>> GetAll(string entity = null, bool? isActive = null, bool? populateEntityName = null, long? entityId = null);

        Task<IResult<List<UserDetail>>> Search(string search, string entity = null, bool? isActive = null);
    }
}