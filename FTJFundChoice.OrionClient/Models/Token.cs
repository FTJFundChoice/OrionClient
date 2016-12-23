using System;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models {

    [DataContract()]
    public class Token {

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