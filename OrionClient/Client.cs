using RestSharp;

namespace OrionClient {

    public class Client {
        private IRestClient client = null;

        public Client(string baseUrl, string username, string password) {
            client = new RestClient(baseUrl);
            client.Authenticator = new OrionAuthenticator(username, password);
        }
    }
}