using FTJFundChoice.OrionModels;
using FTJFundChoice.OrionModels.Portfolio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [TestClass]
    public class RepresentativeTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Portfolio.Representatives.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].Portfolio.Number);
        }

        [TestMethod]
        public async Task Get() {
            var result = await Client.Portfolio.Representatives.Get(349);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.Number);
        }

        [TestMethod]
        public async Task GetWithUserDefinedFields() {
            var result = await Client.Portfolio.Representatives.Get(349, false, true);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.UserDefinedFields);
        }

        [TestMethod]
        public async Task Create() {
            var rep = new Representative {
                Name = "Orion Test",
                Portfolio = new RepresentativePortfolio {
                    Address1 = "TEST ADDRESS",
                    BusinessPhone = "123-123-1234",
                    City = "TEST",
                    State = "KY",
                    Zip = "12345",
                    Number = Guid.NewGuid().ToString(),
                    Email = "test@123.abc",
                    FirstName = "TEST",
                    LastName = "TEST",
                    Name = "Orion Test",
                    BrokerDealerId = 3,
                    WholesalerId = 3
                }
            };
            var result = await Client.Portfolio.Representatives.Create(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public async Task Update() {
            var result = await Client.Portfolio.Representatives.Get(1);

            var rep = result.Data;
            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            result = await Client.Portfolio.Representatives.Update(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public async Task UpdateWithUserDefinedFields() {
            var result = await Client.Portfolio.Representatives.Get(1, true, true);
            var rep = result.Data;

            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            var udf = rep.UserDefinedFields.FirstOrDefault(x => x.UserDefineDefinitionId == 491); // CRD2
            udf.Value = "INTEGRATION_TEST";

            result = await Client.Portfolio.Representatives.Update(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}