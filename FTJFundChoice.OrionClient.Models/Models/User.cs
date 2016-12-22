using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Model {

    [DataContract()]
    public class User {

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "isActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "activeDate")]
        public DateTime ActiveDate { get; set; }

        [DataMember(Name = "inactiveDate")]
        public DateTime InactiveDate { get; set; }

        [DataMember(Name = "lastLogin")]
        public DateTime LastLogin { get; set; }

        [DataMember(Name = "lastPasswordChange")]
        public DateTime LastPasswordChange { get; set; }

        [DataMember(Name = "isReset")]
        public bool IsReset { get; set; }

        [DataMember(Name = "mobilePhone")]
        public string MobilePhone { get; set; }

        [DataMember(Name = "businessPhone")]
        public string BusinessPhone { get; set; }

        [DataMember(Name = "businessPhoneExtension")]
        public string BusinessPhoneExtension { get; set; }

        [DataMember(Name = "Company")]
        public string Company { get; set; }

        [DataMember(Name = "jobTitle")]
        public string JobTitle { get; set; }

        [DataMember(Name = "entityName")]
        public string EntityName { get; set; }

        [DataMember(Name = "profiles")]
        public List<Profile> Profiles { get; set; }
    }
}