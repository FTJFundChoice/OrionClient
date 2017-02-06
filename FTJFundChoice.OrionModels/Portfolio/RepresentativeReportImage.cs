using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class RepresentativeReportImage {

        [JsonProperty("representativeId")]
        public int RepresentativeId { get; set; }

        [JsonProperty("image")]
        public byte[] Image { get; set; }

        [JsonProperty("height")]
        public decimal Height { get; set; }

        [JsonProperty("width")]
        public decimal Width { get; set; }

        [JsonProperty("barColor")]
        public string BarColor { get; set; }
    }
}