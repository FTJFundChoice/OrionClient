using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Portfolio;

namespace FTJFundChoice.OrionClient.Interfaces.Clients {

    public interface IClientsSimpleModule : IQueryModule<ClientSimple>, ISearchModule<ClientSimple> {
    }
}