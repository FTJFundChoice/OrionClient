using FTJFundChoice.OrionClient.Models.Billing;
using FTJFundChoice.OrionClient.Settings;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class RepresentativeVerbose {

        [JsonProperty("billRepresentativePlatforms")]
        public List<BillRepresentativePlatform> BillRepresentativePlatforms { get; set; }

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
        public RepresentativePortfolio Portfolio { get; set; }

        [JsonProperty("reportImage")]
        public RepresentativeReportImage ReportImage { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<EntityOption> UserDefinedFields { get; set; }
    }
}