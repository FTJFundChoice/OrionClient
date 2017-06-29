using Newtonsoft.Json;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Conversion
{
	[Collection("Exception Tests")]
	public class ExceptionConversionTests
	{
		private const string detailSample = "{\"correlationId\":\"cb3f1086-21c0-4d8a-9768-2245562253c4\",\"developerException\":null,\"userException\":{\"type\":\"DetailedException\",\"detail\":[{\"key\":\"Number\",\"value\":\"Representative Number already exists.\"},{\"key\":\"Number\",\"value\":\"Representative Number already exists 2.\"}]}}";
		private const string simpleSample = "{\"correlationId\":\"8dd5f385-9edc-40d0-8787-dda742279ee7\",\"developerException\":null,\"userException\":{\"type\":\"SimpleException\",\"detail\":\"Cannot insert duplicate key row in object 'dbo.tblRep' with unique index 'UDX_tblRep_RepNo'. The duplicate key value is (000058_000000001_0000009BL).\r\nThe statement has been terminated.\" } }";

		[Fact]
		public void SimpleExceptionConversionTest()
		{
			var dynEx = JsonConvert.DeserializeObject<dynamic>(simpleSample);

			OrionException exception = new OrionException(dynEx);

			Assert.Equal(exception.CorrelationId, "8dd5f385-9edc-40d0-8787-dda742279ee7");
			Assert.Equal(exception.Exception.Detail, "Cannot insert duplicate key row in object 'dbo.tblRep' with unique index 'UDX_tblRep_RepNo'. The duplicate key value is (000058_000000001_0000009BL).\r\nThe statement has been terminated.");
		}

		[Fact]
		public void DetailedExceptionConversionTest()
		{
			var dynEx = JsonConvert.DeserializeObject<dynamic>(detailSample);

			OrionException exception = new OrionException(dynEx);

			Assert.Equal(exception.CorrelationId, "cb3f1086-21c0-4d8a-9768-2245562253c4");
			Assert.Equal(exception.Exception.Detail, "Representative Number already exists. Representative Number already exists 2. ");
		}
	}
}
