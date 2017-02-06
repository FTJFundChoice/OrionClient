using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Security {

    public class UserInfoDetails {

        [JsonProperty("activeDate")]
        public DateTime? ActiveDate { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("businessPhoneExtension")]
        public string BusinessPhoneExtension { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("inactiveDate")]
        public DateTime? InactiveDate { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("isReset")]
        public bool IsReset { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastPasswordChange")]
        public DateTime? LastPasswordChange { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}