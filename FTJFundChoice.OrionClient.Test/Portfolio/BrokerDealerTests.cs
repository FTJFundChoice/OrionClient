using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [Collection(@"Broker\Dealer Tests")]
    public class BrokerDealerTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Portfolio.BrokerDealers.Verbose.GetAllAsync();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count > 0);
            Assert.NotNull(result.Data[0].Portfolio.OldBDCode);
        }

        [Fact]
        public async Task Get() {
            var result = await Client.Portfolio.BrokerDealers.Verbose.GetAsync(3);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data.Portfolio.OldBDCode);
        }

        [Fact]
        public async Task Create() {
            var dealers = new Compositions.BrokerDealers.BrokerDealersVerboseModule(Client);
            var dealer = new BrokerDealerVerbose {
                Name = "Orion Test",
                Portfolio = new BrokerDealerPortfolio {
                    Address1 = "TEST ADDRESS",
                    BusinessPhone = "123-123-1234",
                    City = "TEST",
                    State = "KY",
                    Zip = "12345",
                    OldBDCode = Guid.NewGuid().ToString().Substring(0, 6),
                    Email = "test@123.abc",
                    Name = "Orion Test"
                }
            };
            var result = await Client.Portfolio.BrokerDealers.Verbose.CreateAsync(dealer);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task Update() {
            var result = await Client.Portfolio.BrokerDealers.Verbose.GetAsync(337);

            var dealer = result.Data;
            dealer.Portfolio.Address1 = "TEST ADDRESS 2";

            result = await Client.Portfolio.BrokerDealers.Verbose.UpdateAsync(dealer);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }
    }
}