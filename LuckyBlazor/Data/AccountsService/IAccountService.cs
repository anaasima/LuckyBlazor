using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.AccountsService
{
    public interface IAccountService
    {
        Task RegisterAccount(Account Account);
        Task<Account> ValidateAccount(string Username, string Password);

    }
}