using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionModels.Portfolio;

namespace FTJFundChoice.OrionClient.Compositions.BrokerDealers {

    public class BrokerDealersSimpleModule : ISearchModule<BrokerDealerSimple> {

        public Task<IResult<List<BrokerDealerSimple>>> Search(string search) {
            throw new NotImplementedException();
        }
    }
}