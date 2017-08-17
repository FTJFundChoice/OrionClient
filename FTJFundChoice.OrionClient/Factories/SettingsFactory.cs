
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionClient.Compositions.Settings;
using FTJFundChoice.OrionClient.Interfaces.Settings;

namespace FTJFundChoice.OrionClient.Factories
{
    public class SettingsFactory : ISettingsFactory
    {
        private readonly OrionApiClient client;

        public SettingsFactory(OrionApiClient client)
        {
            this.client = client;
        }

        public ISettingsModule CustomSettings
        {
            get
            {
                return new SettingsModule(client);
            }
        }
    }
}
