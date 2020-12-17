using System;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum.Report
{
    public class Report
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("postId")]
        public int PostId { get; set; }
        [JsonPropertyName("username")]
        public String Username { get; set; }

        public Report()
        {
            
        }
        
        public Report(int userId, int postId, string username)
        {
            this.UserId = userId;
            this.PostId = postId;
            Username = username;
        }
    }
}