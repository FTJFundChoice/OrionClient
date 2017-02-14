using FTJFundChoice.OrionClient.Interfaces.Clients;

namespace FTJFundChoice.OrionClient.Compositions.Clients {

    public class ClientsModule : IClientsModule {
        private OrionApiClient client = null;
        private IClientsSimpleModule simpleModule = null;

        public ClientsModule(OrionApiClient client) {
            this.client = client;
            simpleModule = new ClientSimpleModule(client);
        }

        public IClientsSimpleModule Simple {
            get {
                return simpleModule;
            }
        }
    }
}