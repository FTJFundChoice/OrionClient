using System;
using FTJFundChoice.OrionClient.Interfaces.OrionClient;
using FTJFundChoice.OrionClient.Compositions.OrionClient;

namespace FTJFundChoice.OrionClient.Compositions.OrionClient {

    public class ClientsModule : IClientsModule {
        private OrionApiClient client = null;
        private IClientsSimpleModule simpleModule = null;

        public ClientsModule(OrionApiClient client) {
            this.client = client;
            simpleModule = new ClientSimpleModule(client);
        }

        public IClientsSimpleModule Simple {
            get {
                throw new NotImplementedException();
            }
        }
    }
}