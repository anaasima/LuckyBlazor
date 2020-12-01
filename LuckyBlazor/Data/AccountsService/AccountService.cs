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

            HttpResponseMessage responseMessage = await httpClient.PostAsync("http://localhost:8080/register", content);
            Console.WriteLine(responseMessage);
        }

        public async Task<Account> ValidateAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            string accountSerialized = JsonSerializer.Serialize(account);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:8080/login"),
                Content = new StringContent(accountSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();

            // Console.WriteLine(s);
            // Account accountdummy = JsonSerializer.Deserialize<Account>(s);
            // Console.WriteLine("asdasdasdads" + accountdummy.UserId + " " + accountdummy.Username);
            return JsonSerializer.Deserialize<Account>(s);
        }

        public async Task DeleteAccount(int userId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync("http://localhost:8080/accounts/" + userId);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task EditAccount(Account account)
        {
            HttpClient client = new HttpClient();
            
            string accountSerialized = JsonSerializer.Serialize(account);
            
            StringContent content = new StringContent(
                accountSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PatchAsync("http://localhost:8080/accounts", content);
            Console.WriteLine("USERID in account service" + account.UserId);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}