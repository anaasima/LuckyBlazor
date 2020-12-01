using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Forum;

namespace LuckyBlazor.Data.ForumService
{
    public class ForumService : IForumService
    {
        public async Task<PostList> GetAllPosts()
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/posts"; 
            string message = await httpClient.GetStringAsync(uri);
            PostList result = JsonSerializer.Deserialize<PostList>(message) ;
            return result;
        }
    }
}