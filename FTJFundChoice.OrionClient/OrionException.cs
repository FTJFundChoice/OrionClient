using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient
{

	public class OrionException {

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("userException")]
        public UserException Exception { get; set; }

		/*
		 * Most efficient? Dynamic feels dirty and expensive. 
		*/
		public OrionException(dynamic ex)
		{
			if (ex != null)
			{
				Message = ex.message?.ToString();
				CorrelationId = ex.correlationId?.ToString();
				if (ex.userException != null) {
					Exception = new UserException(ex);
				}
			}
		}

		public override string ToString() {
			return $"{Message} - {Exception} - {CorrelationId}";
		}
    }

	public class UserException
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("detail")]
		public string Detail { get; set; }

		/*
		 * Most efficient? Dynamic feels dirty and expensive. 
		*/
		public UserException(dynamic ex)
		{
			if (ex != null)
			{
				Type = ex.userException.type.ToString();

				if (Type.Equals("SimpleException", System.StringComparison.OrdinalIgnoreCase))
					Detail = ex.userException.detail.ToString();

				if (Type.Equals("DetailedException", System.StringComparison.OrdinalIgnoreCase))
				{
					List<DetailedKeyValue> collection = JsonConvert.DeserializeObject<List<DetailedKeyValue>>(ex.userException.detail.ToString());

					collection.ForEach((x) => {
						Detail += string.Format("{0} ", x.Value);
					});
				}
			}
		}

		public override string ToString()
		{
			return $"{Type} - {Detail}";
		}
	}

	internal class DetailedKeyValue
	{
		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}