using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Accounts
{
	public interface IAccountsModule
	{
		Task<IResult<Account>> GetAccountByAccountNumber(string accountNumber);
	}
}
