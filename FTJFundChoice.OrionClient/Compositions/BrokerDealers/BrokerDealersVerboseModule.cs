using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Interfaces.BrokerDealers;
using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Enums;
using Newtonsoft.Json;
using FTJFundChoice.OrionClient.Extensions;
using FTJFundChoice.OrionClient.Models.Enums;

namespace FTJFundChoice.OrionClient.Compositions.BrokerDealers {

    public class BrokerDealersVerboseModule : IBrokerDealersVerboseModule {
        private OrionApiClient client = null;

        public BrokerDealersVerboseModule(OrionApiClient client) {
            this.client = client;
        }

        public async Task<IResult<BrokerDealerVerbose>> CreateAsync(BrokerDealerVerbose brokerDealer) {
            var request = new Request("Portfolio/BrokerDealers/Verbose", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer));

            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }

        public async Task<IResult<BrokerDealerVerbose>> UpdateAsync(BrokerDealerVerbose brokerDealer) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/{id}", Method.PUT);

            request.AddUrlSegment("id", brokerDealer.Id.ToString());

            request.AddParameter("application/json", JsonConvert.SerializeObject(brokerDealer));

            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }

        public Task<IResult> DeleteAsync(long[] id) {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(long id) {
            throw new NotImplementedException();
        }

        public async Task<IResult<BrokerDealerVerbose>> GetAsync(long id) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }

        public async Task<IResult<IEnumerable<BrokerDealerVerbose>>> GetAll() {
            return await GetAllAsync(5000, 0, true);
        }

		public async Task<IResult<IEnumerable<BrokerDealerVerbose>>> GetAllAsync(params BrokerDealerExpands[] expands)
		{
			return await GetAllAsync(5000, 0, true, expands);
		}

		public async Task<IResult<IEnumerable<BrokerDealerVerbose>>> GetAllAsync(int top = 5000, int skip = 0, bool? isActive = true) {
            var request = new Request("Portfolio/BrokerDealers/Verbose", Method.GET);
            request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<IEnumerable<BrokerDealerVerbose>>(request);
        }

        public async Task<IResult<IEnumerable<BrokerDealerVerbose>>> GetAllAsync(int top = 5000, int skip = 0, bool? isActive = false, params BrokerDealerExpands[] expands) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/", Method.GET);
			request.AddExpandQueryParameters(Array.ConvertAll<BrokerDealerExpands, int>(expands, delegate (BrokerDealerExpands value) { return (int)value; }));
			request.AddTopSkipQueryParameters(top, skip);
            request.AddActiveQueryParameters(isActive);
            return await client.ExecuteTaskAsync<IEnumerable<BrokerDealerVerbose>>(request);
        }

        public async Task<IResult<BrokerDealerVerbose>> GetAsync(long id, params BrokerDealerExpands[] expands) {
            var request = new Request("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", Convert.ToString(id));
			request.AddExpandQueryParameters(Array.ConvertAll<BrokerDealerExpands, int>(expands, delegate (BrokerDealerExpands value) { return (int)value; }));

			return await client.ExecuteTaskAsync<BrokerDealerVerbose>(request);
        }
    }
}