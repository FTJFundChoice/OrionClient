using System;
using System.Linq;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models.Extensions {

    public static class EnumExtensions {

        public static T GetAttributesOfType<T>(this Enum enumValue) where T : Attribute {
            var type = enumValue.GetType();
            var memInfo = type.GetMember(enumValue.ToString());
            var attributes = memInfo[0].GetCustomAttributes(type, false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static T GetEnumFromMemberValue<T>(string value) {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields()) {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(EnumMemberAttribute)) as EnumMemberAttribute;
                if (attribute != null) {
                    if (attribute.Value == value)
                        return (T)field.GetValue(null);
                }
                else {
                    if (field.Name == value)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Entity not found in enumeration.", value);
        }

        public static string GetMemberValue<T>(this T enumVal) {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            var field = type.GetFields().Where(x => x.Name == enumVal.ToString()).FirstOrDefault();
            if (field == null) throw new ArgumentException(string.Format("Unrecognized enum value {0} for type {1}", enumVal.ToString(), typeof(T)));

            var attribute = Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute)) as EnumMemberAttribute;
            if (attribute == null) return enumVal.ToString();

            return attribute.Value;
        }
    }
}