namespace OrionClient.Interfaces {

    public interface ISecurityModule {
        IUserModule Users { get; }
        IProfileModule Profiles { get; }

        Result ImpersonationToken(string entity, string entityId);
    }
}