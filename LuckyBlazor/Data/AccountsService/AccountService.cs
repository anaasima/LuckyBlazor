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
        public async Task<string> RegisterAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            string accountSerialized = JsonSerializer.Serialize(account);

            // StringContent content = new StringContent(
            //     accountSerialized,
            //     Encoding.UTF8,
            //     "application/json"
            // );
            //
            // HttpResponseMessage responseMessage = await httpClient.PostAsync("http://localhost:8080/register", content);
            // Console.WriteLine(responseMessage.StatusCode);
            // return responseMessage.StatusCode.ToString();
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:8080/register"),
                Content = new StringContent(accountSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            Console.WriteLine(s);
            return s;
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
            return JsonSerializer.Deserialize<Account>(s);
        }

        public async Task DeleteAccount(int userId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync("http://localhost:8080/delete/" + userId);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task<string> EditAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            
            string accountSerialized = JsonSerializer.Serialize(account);
            
            // StringContent content = new StringContent(
            //     accountSerialized,
            //     Encoding.UTF8,
            //     "application/json"
            // );
            //
            // HttpResponseMessage responseMessage = await client.PatchAsync("http://localhost:8080/accounts", content);
            // Console.WriteLine(responseMessage.StatusCode.ToString());
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:8080/update"),
                Content = new StringContent(accountSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            Console.WriteLine(s);
            return s;
        }

        public async Task<Account> GetUserByUsername(string username)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/accounts?Username=" + username;

            Console.WriteLine(uri);
            
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine(message);
            
            Account result = JsonSerializer.Deserialize<Account>(message);
            return result;
        }

    }
}