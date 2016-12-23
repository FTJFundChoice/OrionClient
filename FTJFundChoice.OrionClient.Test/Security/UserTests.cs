using FTJFundChoice.OrionModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class UserTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Security.Users.GetAll();
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].EntityName);
        }

        [TestMethod]
        public async Task Get() {
            var result = await Client.Security.Users.Get(65258);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.EntityName);
        }

        [TestMethod]
        public async Task Create() {
            var user = new User {
                EntityName = "ORION_CLIENT_TEST",
                UserId = Guid.NewGuid().ToString(),
                Email = "ORION_CLIENT@TEST.123",
                LastName = "ORION_LAST_TEST",
                Profiles = new List<Profile>()
            };

            user.Profiles.Add(new Profile {
                LoginEntityId = LoginEntityId.Rep,
                EntityId = 6723,
                IsUserDefault = true,
                IsInCurrentDb = true,
                AlClientId = AlClientId,
                // Only need these values in testapi.
                // Sigh.
                RoleId = 1458,
                RoleName = "Representative"
            });

            var result = await Client.Security.Users.Create(user);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public async Task Update() {
            var result = await Client.Security.Users.Get(69949);
            var user = result.Data;
            user.FirstName = "ORION_TEST";

            result = await Client.Security.Users.Update(user);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}