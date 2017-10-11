using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Models.Settings
{
    public class Logo
    {
        [JsonProperty("promptName")]
        public string PromptName { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("value")]
        public string ImageStream { get; set; }
        [JsonProperty("optionLevel")]
        public string OptionLevel { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("displayOrder")]
        public int displayorder { get; set; }
        [JsonProperty("customAppSetting")]
        public string CustomAppSetting { get; set; }

    }
}
