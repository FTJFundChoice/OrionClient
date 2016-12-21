using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrionClient.Model;
using System;
using System.Linq;
using System.Net;

namespace OrionClient.Test.Portfolio {

    [TestClass]
    public class RepresentativeTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var result = Client.Portfolio.Representatives.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].Portfolio.Number);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.Representatives.Get(349);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.Number);
        }

        [TestMethod]
        public void GetWithUserDefinedFields() {
            var result = Client.Portfolio.Representatives.Get(349, false, true);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.Number);
        }

        [TestMethod]
        public void Create() {
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
            var result = Client.Portfolio.Representatives.Create(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void Update() {
            var rep = Client.Portfolio.Representatives.Get(1).Data;

            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            var result = Client.Portfolio.Representatives.Update(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void UpdateWithUserDefined() {
            var rep = Client.Portfolio.Representatives.Get(1, true, true).Data;

            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            var udf = rep.UserDefinedFields.FirstOrDefault(x => x.UserDefineDefinitionId == 491); // CRD2
            udf.Value = "INTEGRATION_TEST";

            var result = Client.Portfolio.Representatives.Update(rep);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}