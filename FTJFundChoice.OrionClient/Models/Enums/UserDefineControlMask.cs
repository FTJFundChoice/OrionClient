using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models.Enums {

    public enum UserDefineControlMask {
        [EnumMember(Value = "Multi-line editor")]
        MultiLineEditor = -2,
        DropDownEditor = -1,
        [EnumMember(Value = "List")]
        DropDownList = 0,
		[EnumMember(Value = "Check box")]
		CheckBox = 1,
        Currency = 2,
        Date = 3,
        [EnumMember(Value = "Date/Time")]
        DateTime = 4,
        Integer = 5,
        String = 6,
        Double = 7,
        Time = 8,
        Long = 11,
		[EnumMember(Value = "Custom object")]
		CustomObject = 12        
    }
}