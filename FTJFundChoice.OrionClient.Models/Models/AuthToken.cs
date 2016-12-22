using System;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Model {

    [DataContract()]
    public class AuthToken {

        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "expires_in")]
        public long ExpiresIn { get; set; }

        public DateTime ExpirationDate {
            get {
                return DateTime.Now.AddMilliseconds(ExpiresIn);
            }
        }
    }
}