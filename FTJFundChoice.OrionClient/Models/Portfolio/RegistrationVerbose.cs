using System;
using FTJFundChoice.OrionClient.Models.Billing;
using FTJFundChoice.OrionClient.Models.Settings;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace FTJFundChoice.OrionClient.Models.Portfolio
{
    public class RegistrationVerbose
    {
        [JsonProperty("id")]
        public int RegistrationId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("contact")]
        public string Contact { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("beneficiaries")]
        public string Beneficiaries { get; set; }
        [JsonProperty("suitability")]
        public string Suitability { get; set; }
        [JsonProperty("userDefinedFields")]
        public string UserDefinedFields { get; set; }
        [JsonProperty("entityOptions")]
        public string EntityOptions { get; set; }
        [JsonProperty("portfolio")]
        public RepresentativePortfolio Portfolio { get; set; }
    }
}
