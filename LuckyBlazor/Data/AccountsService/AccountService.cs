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
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/register"),
                Content = new StringContent(accountSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            return s;
        }

        public async Task<Account> ValidateAccount(Account account)
        {
            HttpClient httpClient = new HttpClient();
            string accountSerialized = JsonSerializer.Serialize(account);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/login"),
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
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/update"),
                Content = new StringContent(accountSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            return s;
        }

        public async Task<Account> GetUserByUsername(string username)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts?Username=" + username;
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine("ASDASDASD" + message);

            Account result = JsonSerializer.Deserialize<Account>(message);
            return result;
        }

        public async Task<Account> GetUserById(int id)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts/" + id;
            string message = await httpClient.GetStringAsync(uri);
            Account result = JsonSerializer.Deserialize<Account>(message);
            return result;
        }

        public async Task FollowAccount(int userId, int userToFollow)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(
                String.Concat(userToFollow),
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/followAccount/" + userId, content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task UnfollowAccount(int userId, int userToUnfollow)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(
                String.Concat(userToUnfollow),
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/unfollowAccount/" + userId, content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task<IList<Account>> GetFollowedAccounts(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/followedAccounts/" + userId;
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine(message);
            
            IList<Account> result = JsonSerializer.Deserialize<IList<Account>>(message);
            return result;
        }
    }
}