using System;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum.Report
{
    public class Report
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        [JsonPropertyName("postId")]
        public int postId { get; set; }
        [JsonPropertyName("username")]
        public String Username { get; set; }

        public Report()
        {
            
        }
        
        public Report(int userId, int postId, string username)
        {
            this.userId = userId;
            this.postId = postId;
            Username = username;
        }
    }
}