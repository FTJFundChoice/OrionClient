using System;
using System.Configuration;

namespace FTJFundChoice.OrionClient.Test {

    public abstract class BaseTest {
        public OrionApiClient Client { get; private set; }
        public int AlClientId { get; private set; }

        public BaseTest() {
            var baseUrl = ConfigurationManager.AppSettings["apiUrl"];

            var apiCreds = new Credentials {
                Username = ConfigurationManager.AppSettings["api_username"],
                Password = ConfigurationManager.AppSettings["api_password"]
            };

            var svcCreds = new Credentials {
                Username = ConfigurationManager.AppSettings["svc_username"],
                Password = ConfigurationManager.AppSettings["svc_password"]
            };

            Client = new OrionApiClient(baseUrl, apiCreds, svcCreds, TimeSpan.FromMinutes(5));

            AlClientId = Convert.ToInt32(ConfigurationManager.AppSettings["alClientId"]);
        }
    }
}