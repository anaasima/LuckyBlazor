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
            
            HttpResponseMessage responseMessage = await httpClient.PostAsync("http://localhost:8080/accounts", content);
            Console.WriteLine(responseMessage);
        }

        public async Task<Account> ValidateAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/accounts";
            string message = await httpClient.GetStringAsync(uri + $"?Username={account.Username}");
            Account dummy = JsonSerializer.Deserialize<Account>(message);
            return dummy;
        }
    }
}