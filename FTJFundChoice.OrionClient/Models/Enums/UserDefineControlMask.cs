using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models.Enums {

    public enum UserDefineControlMask {
        MultiLineEditor = -2,
        DropDownEditor = -1,
        DropDownList = 0,
		[EnumMember(Value = "Check box")]
		CheckBox = 1,
        Currency = 2,
        Date = 3,
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