using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Interfaces;
using FTJFundChoice.OrionModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions {

    public class WholesalersModule : IWholesalersModule {
        private Client client = null;

        public WholesalersModule(Client client) {
            this.client = client;
        }

        public async Task<IResult<Wholesaler>> Get(long id) {
            var request = new Request("Portfolio/Wholesalers/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<Wholesaler>(request);
        }

        public async Task<IResult<List<Wholesaler>>> GetAll(int top = 1000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/Wholesalers", Method.GET);
            return await client.ExecuteTaskAsync<List<Wholesaler>>(request);
        }
    }
}