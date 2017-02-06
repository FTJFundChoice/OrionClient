using FTJFundChoice.OrionModels.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class BrokerDealerVerbose {

        [JsonProperty("documents")]
        public List<Document> Documents { get; set; }

        [JsonProperty("entityOptions")]
        public List<EntityOption> EntityOptions { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("portfolio")]
        public BrokerDealerPortfolio Portfolio { get; set; }

        [JsonProperty("reportImage")]
        public BrokerDealerReportImage ReportImage { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<EntityOption> UserDefinedFields { get; set; }

        [JsonProperty("additionalContacts")]
        public List<BrokerDealerAdditionalContact> AdditionalContacts { get; set; }
    }
}