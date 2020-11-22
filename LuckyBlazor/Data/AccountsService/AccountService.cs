using System;
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
        public async Task RegisterAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            string accountSerialized = JsonSerializer.Serialize(account);
            
            StringContent content = new StringContent(
                accountSerialized,
                Encoding.UTF8,
                "application/json"
                );
            
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/accounts", content);
            Console.WriteLine(responseMessage);
        }

        public async Task<Account> ValidateAccount(string username, string password)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts";
            string message = await httpClient.GetStringAsync(uri + $"?UserName={username}&Password={password}");
            Account account = JsonSerializer.Deserialize<Account>(message);
            return account;
        }
    }
}