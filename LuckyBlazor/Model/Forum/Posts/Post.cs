using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum
{
    public class Post
    {
        [JsonPropertyName("id")]
        public int PostId { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("upVotes")]
        public int UpVotes { get; set; }
        [JsonPropertyName("downVotes")]
        public int DownVotes { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}