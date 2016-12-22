﻿using OrionClient.Compositions;
using OrionClient.Interfaces;
using RestSharp;

namespace OrionClient {

    public class Client {
        private IRestClient client = null;
        private IPortfolioModule portfolioModule;
        private ISecurityModule securityModule;

        public Client(string baseUrl, Credentials apiCredentials) {
            client = new RestClient(baseUrl);
            client.Authenticator = new OrionAuthenticator(apiCredentials);

            portfolioModule = new PortfolioModule(client);
            securityModule = new SecurityModule(client);
        }

        public IPortfolioModule Portfolio {
            get {
                return portfolioModule;
            }
        }

        public ISecurityModule Security {
            get {
                return securityModule;
            }
        }
    }
}