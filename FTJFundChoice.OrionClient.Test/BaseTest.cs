using System;
using System.Configuration;

namespace FTJFundChoice.OrionClient.Test {

    public abstract class BaseTest {
        public OrionClient.Client Client { get; private set; }
        public int AlClientId { get; private set; }

        public BaseTest() {
            var baseUrl = ConfigurationManager.AppSettings["apiUrl"];

            var apiCreds = new Credentials {
                Username = ConfigurationManager.AppSettings["api_username"],
                Password = ConfigurationManager.AppSettings["api_password"]
            };

            Client = new OrionClient.Client(baseUrl, apiCreds);

            AlClientId = Convert.ToInt32(ConfigurationManager.AppSettings["alClientId"]);
        }
    }
}