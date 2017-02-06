using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class Document {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }

        [JsonProperty("editedDate")]
        public DateTime EditedDate { get; set; }

        [JsonProperty("systemGenerated")]
        public bool SystemGenerated { get; set; }
    }
}