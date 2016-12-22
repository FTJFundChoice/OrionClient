using OrionClient.Model;

namespace OrionClient.Interfaces {

    public interface IUserModule : ICommonRead<User>, ICommonModify<User> {
    }
}