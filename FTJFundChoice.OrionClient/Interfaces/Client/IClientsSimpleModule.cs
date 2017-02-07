using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;

namespace FTJFundChoice.OrionClient.Interfaces.OrionClient {

    public interface IClientsSimpleModule : IQueryModule<ClientSimple>, ISearchModule<ClientSimple> {
    }
}