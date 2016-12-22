using Microsoft.VisualStudio.TestTools.UnitTesting;
using FTJFundChoice.OrionClient.Models;
using System;
using System.Net;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [TestClass]
    public class BrokerDealerTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var result = Client.Portfolio.BrokerDealers.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].Portfolio.OldBDCode);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.BrokerDealers.Get(3);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.OldBDCode);
        }

        [TestMethod]
        public void Create() {
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
            var result = Client.Portfolio.BrokerDealers.Create(dealer);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void Update() {
            var dealer = Client.Portfolio.BrokerDealers.Get(337).Data;
            dealer.Portfolio.Address1 = "TEST ADDRESS 2";

            var result = Client.Portfolio.BrokerDealers.Update(dealer);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}