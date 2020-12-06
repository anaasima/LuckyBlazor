using System;
using System.Net.Http;
using System.Text;
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

        public async Task<PostList> GetPostsByUserId(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/posts?userId=" + userId;
            string message = await httpClient.GetStringAsync(uri);
            PostList result = JsonSerializer.Deserialize<PostList>(message);
            return result;
        }

        public async Task CreatePost(Post post)
        {
            HttpClient httpClient = new HttpClient();
            string postSerialized = JsonSerializer.Serialize(post);
            StringContent content = new StringContent(
                postSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = await httpClient.PostAsync
                ("http://localhost:8080/posts", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}