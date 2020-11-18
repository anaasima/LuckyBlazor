using System.Net.Http;
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
            string uri = "https://localhost:8080/builds/" + $"{userId}";
            string message = await httpClient.GetStringAsync(uri);
            BuildList result = JsonSerializer.Deserialize<BuildList>(message);
            return result;
        }
    }
}