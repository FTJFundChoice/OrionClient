using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System.IO;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace FTJFundChoice.OrionClient {

    public interface IJsonSerializer : ISerializer, IDeserializer { }

    public class OrionJsonSerializer : IJsonSerializer {
        private JsonSerializer serializer;

        public OrionJsonSerializer(JsonSerializer serializer) {
            this.serializer = serializer;
        }

        public string ContentType {
            get { return "application/json"; }
            set { }
        }

        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public string Serialize(object obj) {
            using (var stringWriter = new StringWriter()) {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter)) {
                    serializer.Serialize(jsonTextWriter, obj);

                    return stringWriter.ToString();
                }
            }
        }

        public T Deserialize<T>(RestSharp.IRestResponse response) {
            var content = response.Content;

            using (var stringReader = new StringReader(content)) {
                using (var jsonTextReader = new JsonTextReader(stringReader)) {
                    return serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }

        public static OrionJsonSerializer Default {
            get {
                var serializer = new JsonSerializer() {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Include
                };
                serializer.Converters.Add(new StringEnumConverter());
                return new OrionJsonSerializer(serializer);
            }
        }
    }
}