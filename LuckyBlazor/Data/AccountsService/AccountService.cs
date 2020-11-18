using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.AccountsService
{
    public class AccountService : IAccountService
    {
        public async Task RegisterAccount(Account Account)
        {
            HttpClient httpClient = new HttpClient();
            string accountSerialized = JsonSerializer.Serialize(Account);
            
            StringContent content = new StringContent(
                accountSerialized,
                Encoding.UTF8,
                "application/json"
                );
            
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:5001/accounts", content);
            
        }

        public async Task<Account> ValidateAccount(string Username, string Password)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts";
            string message = await httpClient.GetStringAsync(uri + $"?UserName={Username}&Password={Password}");
            Account account = JsonSerializer.Deserialize<Account>(message);
            return account;
        }
    }
}