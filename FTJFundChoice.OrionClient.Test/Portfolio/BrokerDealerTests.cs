using FTJFundChoice.OrionModels;
using FTJFundChoice.OrionModels.Portfolio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [TestClass]
    public class BrokerDealerTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Portfolio.BrokerDealers.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].Portfolio.OldBDCode);
        }

        [TestMethod]
        public async Task Get() {
            var result = await Client.Portfolio.BrokerDealers.Get(3);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.OldBDCode);
        }

        [TestMethod]
        public async Task Create() {
            var dealer = new BrokerDealer {
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
            var result = await Client.Portfolio.BrokerDealers.Create(dealer);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public async Task Update() {
            var result = await Client.Portfolio.BrokerDealers.Get(337);

            var dealer = result.Data;
            dealer.Portfolio.Address1 = "TEST ADDRESS 2";

            result = await Client.Portfolio.BrokerDealers.Update(dealer);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}