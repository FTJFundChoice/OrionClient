using FTJFundChoice.OrionClient.Compositions;
using FTJFundChoice.OrionClient.Models.Enums;
using FTJFundChoice.OrionClient.Models.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Security {

    [Collection("User Tests")]
    public class UserTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Security.Users.GetAllAsync(20, 0, true);
            Assert.True(result.Success);
            Assert.True(result.Data.Count() > 0);
            Assert.NotNull(result.Data.ToArray()[0].EntityName);
        }

        [Fact]
        public async Task Get() {
            var result = await Client.Security.Users.GetAsync(288171); // 65258);

            Assert.True(result.Success);
            Assert.NotNull(result.Data.EntityName);
        }

        [Fact]
        public async Task Create() {
            var user = new UserInfoDetails {
                EntityName = "Spécial_character_tést",
                UserId = Guid.NewGuid().ToString(),
                Email = "ORION_CLIENT@TEST.123",
                LastName = "ORION_LAST_TEST",
                Profiles = new List<Profile>()
            };

            user.Profiles.Add(new Profile {
                LoginEntityId = LoginEntityId.Representative,
                Entity = Entity.Representative,
                EntityId = 6723,
                IsUserDefault = true,
                IsInCurrentDb = true,
                AlClientId = AlClientId,
                // Only need these values in testapi.
                // Sigh.
                RoleId = 1458,
                RoleName = "Representative"
            });

            var result = await Client.Security.Users.CreateAsync(user);

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task Update() {
            var users = new UsersModule(Client);
            var result = await users.GetAsync(69949);
            var user = result.Data;
            user.FirstName = "ORION_TEST";

            result = await users.UpdateAsync(user);

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task SetPassword() {
            var users = new UsersModule(Client);
            long userId = Convert.ToInt64(ConfigurationManager.AppSettings["set_password_userId"]);
            string password = ConfigurationManager.AppSettings["set_password_password"];

            var result = await users.SetPasswordAsync(userId, password);

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }
    }
}