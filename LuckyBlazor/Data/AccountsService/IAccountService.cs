using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.AccountsService
{
    public interface IAccountService
    {
        Task RegisterAccount(Account account);
        Task<Account> ValidateAccount(Account account);

        Task DeleteAccount(int userId);

        Task<Account> EditAccount(Account account);
    }
}