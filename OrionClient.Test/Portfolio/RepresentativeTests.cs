using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrionClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrionClient.Test.Portfolio {

    [TestClass]
    public class RepresentativeTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var results = Client.Portfolio.Representatives.GetAll().ToList();

            Assert.IsTrue(results.Count > 0);
            Assert.IsNotNull(results[0].Portfolio.Number);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.Representatives.Get(349);

            Assert.IsNotNull(result.Portfolio.Number);
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

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateWithUserDefinedFields() {
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
            var userDefinedFields = new List<RepresentativeUserDefinedField>();
            userDefinedFields.Add(new RepresentativeUserDefinedField {
                UserDefinedDefinitionId = 394,
                Value = "TEST"
            });

            rep.UserDefinedFields = userDefinedFields;
            var result = Client.Portfolio.Representatives.Create(rep);

            Assert.IsNotNull(result);
        }
    }
}