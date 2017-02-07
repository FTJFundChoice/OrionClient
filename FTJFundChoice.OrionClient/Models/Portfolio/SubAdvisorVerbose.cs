using FTJFundChoice.OrionClient.Models.Portfolio;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Models.ModelsPortfolio {

    public class SubAdvisorVerbose {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("portfolio")]
        public SubAdvisorPortfolio Portfolio { get; set; }

        [JsonProperty("logo")]
        public SubAdvisorLogo Logo { get; set; }

        [JsonProperty("documents")]
        public List<Document> Documents { get; set; }

        [JsonProperty("entities")]
        public List<SubAdvisorEntity> Entities { get; set; }
    }
}