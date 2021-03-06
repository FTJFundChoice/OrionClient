﻿using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class SubAdvisor {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}