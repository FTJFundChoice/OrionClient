using FTJFundChoice.OrionClient.Models;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ISecurityModule {
        IUserModule Users { get; }
        IProfileModule Profiles { get; }

        Task<IResult<Token>> GetToken(string username, string password);

        Task<IResult<Token>> GetImpersonationToken(string entity, string entityId);
    }
}