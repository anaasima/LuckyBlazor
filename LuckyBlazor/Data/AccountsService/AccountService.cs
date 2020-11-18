using System.Net.Http;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.AccountsService
{
    public class AccountService : IAccountService
    {
        public async Task<Account> RegisterAccount(Account Account)
        {
            HttpClient httpClient = new HttpClient();
            return null;
        }

        public Task<Account> ValidateAccount(string Username, string Password)
        {
            throw new System.NotImplementedException();
        }
    }
}