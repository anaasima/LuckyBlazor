using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.BuildService
{
    public class BuildService : IBuildService
    {
        public async Task<BuildList> GetAllBuildsAsync(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/builds?UserId=" + $"{userId}";
            string message = await httpClient.GetStringAsync(uri);
            BuildList result = JsonSerializer.Deserialize<BuildList>(message);
            return result;
        }

        public async Task CreateBuild(Build build)
        {
            HttpClient httpClient = new HttpClient();
            string buildSerialized = JsonSerializer.Serialize(build);
            StringContent content = new StringContent(
                buildSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = 
                await httpClient.PostAsync("http://localhost:8080/builds", content);
        }

        public async Task EditBuild(Build build)
        {
            HttpClient httpClient = new HttpClient();
            string buildSerialized = JsonSerializer.Serialize(build);
            StringContent content = new StringContent(
                buildSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = await httpClient.PatchAsync("http://localhost:8080/builds", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeleteBuild(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync("http://localhost:8080/builds/" + id);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}