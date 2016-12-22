using FTJFundChoice.OrionClient.Models;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface ISecurityModule {
        IUserModule Users { get; }
        IProfileModule Profiles { get; }

        Result<AuthToken> ImpersonationToken(string entity, string entityId);
    }
}