using FTJFundChoice.OrionClient.Interfaces.Common;
using FTJFundChoice.OrionClient.Models.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IUsersModule : IModifyModule<UserInfoDetails>, IQueryModule<UserInfoDetails> {

        Task<IResult<List<long>>> ActivateAsync(bool isActive, List<long> ids);

        Task<IResult<UserInfoDetails>> CreateAsync(UserInfoDetails user, bool sendEmail = false);

        Task<IResult<List<UserInfoDetails>>> GetAllAsync(int top = 1000, int skip = 0, bool? isActive = null, string loginUserId = null);

        Task<IResult<UserInfoDetails>> ResetPasswordAsync(long userId, string password, bool sendEmail = false, bool newUser = false);

        Task<IResult<UserInfoDetails>> ResetPasswordAsync(UserInfoDetails user, bool sendEmail = false, bool newUser = false);

        Task<IResult<UserInfoDetails>> SetPasswordAsync(long userId, string password);

        Task<IResult<UserInfoDetails>> SetPasswordAsync(UserInfoDetails user);
    }
}