using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Interfaces.Accounts;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Compositions
{
	public class AccountsModule : IAccountsModule
	{
		private OrionApiClient client = null;

		public AccountsModule(OrionApiClient client)
		{
			this.client = client;
		}

		public async Task<IResult<Account>> GetAccountByAccountNumber(string accountNumber)
		{
			var request = new Request("Portfolio/Accounts/{accountNumber}", Method.GET);
			request.AddUrlSegment("accountNumber", accountNumber);
			return await client.ExecuteTaskAsync<Account>(request);
		}
	}
}
