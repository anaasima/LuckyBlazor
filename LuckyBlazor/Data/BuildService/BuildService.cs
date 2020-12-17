using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Rating;
using Microsoft.AspNetCore.Http;

namespace LuckyBlazor.Data.BuildService
{
    public class BuildService : IBuildService
    {
        public async Task<IList<Build>> GetAllBuildsAsync(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/builds?UserId=" + $"{userId}";
            string message = await httpClient.GetStringAsync(uri);
            IList<Build> result = JsonSerializer.Deserialize<IList<Build>>(message);
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
                await httpClient.PostAsync("https://localhost:8080/builds", content);
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
            HttpResponseMessage responseMessage = await httpClient.PatchAsync("https://localhost:8080/builds", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeleteBuild(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync("https://localhost:8080/builds/" + id);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task LeaveRating(RatingBuild ratingBuild)
        {
            HttpClient client = new HttpClient();
            string ratingSerialized = JsonSerializer.Serialize(ratingBuild);
            StringContent content = new StringContent(
                ratingSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = await client.PatchAsync("https://localhost:8080/buildRating", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}