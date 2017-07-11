using Xunit;

namespace FTJFundChoice.OrionClient.Test.Client
{

	[Collection("Client Tests")]
    public class ClientTests : BaseTest {
		[Fact]
		public void ExceptionTest()
		{
			OrionException ex = new OrionException(null);
			ex.CorrelationId = "TEST_ID";
			ex.Message = "TEST_MESSAGE";
			ex.Exception = new UserException(null);
			ex.Exception.Type = "TEST_TYPE";
			ex.Exception.Detail = "TEST_DETAIL";

			Assert.Equal($"{ex.Message} - {ex.Exception} - {ex.CorrelationId}", ex.ToString());
		}
    }
}