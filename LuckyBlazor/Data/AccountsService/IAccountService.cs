using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.AccountsService
{
    public interface IAccountService
    {
        Task<string> RegisterAccount(Account account);
        Task<Account> ValidateAccount(Account account);

        Task DeleteAccount(int userId);

        Task<string> EditAccount(Account account);
        Task<Account> GetUserByUsername(string username);
        Task<Account> GetUserById(int id);

        Task FollowAccount(int userId, int userToFollow);

        Task UnfollowAccount(int userId, int userToUnfollow);

        Task<IList<Account>> GetFollowedAccounts(int userId);
    }
}