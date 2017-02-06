using FTJFundChoice.OrionClient.Factories;
using FTJFundChoice.OrionClient.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient {

    public class Client : IClient {

        #region Privates

        private ICompositionFactory factory = null;
        private readonly HttpClient client = null;
        private readonly Authenticator authenticator = null;

        #endregion Privates

        #region Contructor

        public Client(string baseUrl, Credentials apiCredentials, Credentials serviceCredentials) {
            var handler = new HttpClientHandler() { };
            client = new HttpClient(handler);
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            authenticator = new Authenticator(apiCredentials, serviceCredentials);

            // ICompositionFactory is the only singleton, by design.
            factory = new CompositionFactory(this);
        }

        #endregion Contructor

        #region Factories

        public IPortfolioFactory Portfolio {
            get {
                return factory.Portfolio;
            }
        }

        public ISecurityFactory Security {
            get {
                return factory.Security;
            }
        }

        #endregion Factories

        #region Internals

        internal async Task<IResult<T>> ExecuteTaskAsync<T>(Request request) {
            await authenticator.AuthenticateAsync(this, request);
            var result = await client.SendAsync(request);
            return new Result<T>(result);
        }

        #endregion Internals
    }
}