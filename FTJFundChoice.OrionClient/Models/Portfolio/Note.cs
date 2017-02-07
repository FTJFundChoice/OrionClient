using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class Note {

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }

        [JsonProperty("editedDate")]
        public DateTime? EditedDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isSystemGenerated")]
        public bool IsSystemGenerated { get; set; }

        [JsonProperty("isWebVisible")]
        public bool IsWebVisible { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}