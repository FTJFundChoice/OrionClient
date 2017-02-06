using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class BrokerDealerReportImage {

        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("brokerDealerId")]
        public int BrokerDealerId { get; set; }

        [JsonProperty("height")]
        public decimal Height { get; set; }

        [JsonProperty("image")]
        public byte[] Image { get; set; }

        [JsonProperty("width")]
        public decimal Width { get; set; }
    }
}