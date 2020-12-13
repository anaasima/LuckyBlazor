using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum
{
    public class Comment
    {
        [JsonPropertyName("id")]
        public int CommentId { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("postId")]
        public int PostId { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }

        public Comment()
        {
            
        }

        public Comment(string content, int userId, int postId, string username)
        {
            Content = content;
            UserId = userId;
            PostId = postId;
            Username = username;
        }
        public override string ToString()
        {
            return Content;
        }
    }
}