using FTJFundChoice.OrionModels.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Xunit;
using FTJFundChoice.OrionModels.Extensions;

namespace FTJFundChoice.OrionModels.Test {

    public class EntityChecker {

        [JsonProperty("entity")]
        public Entity Entity { get; set; }
    }

    public class EntityConversionTest {

        [Theory]
        [InlineData(Entity.Administrator, "Administrator")]
        [InlineData(Entity.BrokerDealer, "Broker/Dealer")]
        [InlineData(Entity.SubAdvisor, "Sub-advisor")]
        [InlineData(Entity.ServiceAccount, "Service Account")]
        [InlineData(Entity.PlanSponsor, "Plan Sponsor")]
        [InlineData(Entity.ThirdParty, "Third Party")]
        [InlineData(Entity.Advisor, "Advisor")]
        [InlineData(Entity.Participant, "Participant")]
        [InlineData(Entity.ThirdPartyAdministrator, "Third-Party Administrator")]
        [InlineData(Entity.Household, "Household")]
        [InlineData(Entity.Wholesaler, "Wholesaler")]
        [InlineData(Entity.Representative, "Representative")]
        [InlineData(Entity.RepAccountManager, "Rep Account Manager")]
        public void EntityConversionTheory(Entity entity, string value) {
            var json = "{'entity': '" + value + "'}";
            EntityChecker checker = JsonConvert.DeserializeObject<EntityChecker>(json, new StringEnumConverter());
            Assert.Equal(checker.Entity, entity);

            Entity entityChecker = EnumExtensions.GetEnumFromMemberValue<Entity>(value);
            Assert.Equal(entity, entityChecker);

            string enumString = entity.GetMemberValue();
            Assert.Equal(value, enumString);
        }
    }
}