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
        [JsonPropertyName("upVote")]
        public int UpVotes { get; set; }
        [JsonPropertyName("downVote")]
        public int DownVotes { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("CommentList")]
        public CommentList CommentList { get; set; }
    }
}