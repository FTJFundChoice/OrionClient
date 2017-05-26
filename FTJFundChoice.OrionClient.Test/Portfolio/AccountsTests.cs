using FTJFundChoice.OrionClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio
{
	[Collection("Account Tests")]
	public class AccountsTests : BaseTest
	{
		[Theory]
		[InlineData("c21165822")]
		public async Task GetByAccountNumber(string accountNumber)
		{
			var result = await Client.Portfolio.Accounts.GetAccountByAccountNumber(accountNumber);

			Assert.Equal(result.StatusCode, StatusCode.OK);
		}
	}
}
