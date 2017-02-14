using FTJFundChoice.OrionClient.Interfaces.Representatives;

namespace FTJFundChoice.OrionClient.Compositions.Representatives {

    public class RepresentativesModule : IRepresentativesModule {
        private OrionApiClient client = null;
        private IRepresentativesVerboseModule verbose = null;

        public RepresentativesModule(OrionApiClient client) {
            this.client = client;
            verbose = new RepresentativesVerboseModule(client);
        }

        public IRepresentativesVerboseModule Verbose {
            get {
                return verbose;
            }
        }
    }
}