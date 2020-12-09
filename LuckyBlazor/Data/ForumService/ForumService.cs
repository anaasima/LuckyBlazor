using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Forum;
using LuckyBlazor.Model.Forum.Report;
using LuckyBlazor.Model.Rating;
using Microsoft.AspNetCore.Http;

namespace LuckyBlazor.Data.ForumService
{
    public class ForumService : IForumService
    {
        public async Task<IList<Post>> GetAllPosts()
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/posts"; 
            string message = await httpClient.GetStringAsync(uri);
            IList<Post> result = JsonSerializer.Deserialize<IList<Post>>(message) ;
            return result;
        }

        public async Task<IList<Post>> GetPostsByUserId(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/posts?userId=" + userId;
            string message = await httpClient.GetStringAsync(uri);
            IList<Post> result = JsonSerializer.Deserialize<IList<Post>>(message);
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
//TODO remember get with body
        public async Task RatePost(RatingPost ratingPost)
        {
            HttpClient httpClient = new HttpClient();
            string ratingSerialized = JsonSerializer.Serialize(ratingPost);
            StringContent content = new StringContent(
                ratingSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage =
                await httpClient.PatchAsync("http://localhost:8080/postRating", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task CreateComment(Comment comment)
        {
            HttpClient httpClient = new HttpClient();
            string commentSerialized = JsonSerializer.Serialize(comment);
            StringContent content = new StringContent(
                commentSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:8080/postComment", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task SavePosts(Post post, int userId)
        {
            HttpClient httpClient = new HttpClient();
            string postSerialized = JsonSerializer.Serialize(post);
            StringContent content = new StringContent(
                postSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = await httpClient.PostAsync($"http://localhost:8080/savedPosts?UserId={userId}", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeletePost(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"http://localhost:8080/posts?Id={id}");
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task ReportPost(Report report)
        {
            HttpClient httpClient = new HttpClient();
            string reportSerialized = JsonSerializer.Serialize(report);
            StringContent content = new StringContent(
                reportSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("http://localhost:8080/report", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeleteReport(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"http://localhost:8080/reports?Id={id}");
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task<IList<Report>> GetReports()
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/reports"; 
            string message = await httpClient.GetStringAsync(uri);
            IList<Report> result = JsonSerializer.Deserialize<IList<Report>>(message) ;
            return result;
        }
        
        public async Task<IList<Post>> GetSavedPosts(int userId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = $"http://localhost:8080/savedPosts?UserId={userId}";
            string message = await httpClient.GetStringAsync(uri);
            IList<Post> result = JsonSerializer.Deserialize<IList<Post>>(message);
            return result;
        }

    }
}