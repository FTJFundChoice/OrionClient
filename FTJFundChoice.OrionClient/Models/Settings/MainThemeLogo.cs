using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Models.Settings
{
    public class MainThemeLogo
    {
        [JsonProperty("canEdit")]
        public byte[] ImageStream { get; set; }
    }
}
