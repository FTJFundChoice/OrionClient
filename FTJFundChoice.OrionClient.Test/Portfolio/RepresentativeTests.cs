using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [Collection("Representative Tests")]
    public class RepresentativeTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Portfolio.Representatives.GetAll();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count > 0);
            Assert.NotNull(result.Data[0].Portfolio.Number);
        }

        [Fact]
        public async Task Get() {
            var result = await Client.Portfolio.Representatives.Get(349);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data.Portfolio.Number);
        }

        [Fact]
        public async Task GetWithUserDefinedFields() {
            var result = await Client.Portfolio.Representatives.Get(349, false, true);
            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data.UserDefinedFields);
        }

        [Fact]
        public async Task Create() {
            var rep = new RepresentativeVerbose {
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
            var reps = new Compositions.RepresentativesModule(Client);
            var result = await reps.Create(rep);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task Update() {
            var reps = new Compositions.RepresentativesModule(Client);
            var result = await reps.Get(1);

            var rep = result.Data;
            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            result = await reps.Update(rep);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task UpdateWithUserDefinedFields() {
            var reps = new Compositions.RepresentativesModule(Client);
            var result = await reps.Get(1, true, true);
            var rep = result.Data;

            rep.Portfolio.Address1 = "TEST ADDRESS 2";

            var udf = rep.UserDefinedFields.FirstOrDefault(x => x.UserDefineDefinitionId == 491); // CRD2
            udf.Value = "INTEGRATION_TEST";

            result = await reps.Update(rep);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }
    }
}