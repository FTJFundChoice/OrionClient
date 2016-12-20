using System.Configuration;

namespace OrionClient.Test {

    public abstract class BaseTest {
        public Client Client { get; private set; }

        public BaseTest() {
            var baseUrl = ConfigurationManager.AppSettings["apiUrl"];
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];

            Client = new Client(baseUrl, username, password);
        }
    }
}