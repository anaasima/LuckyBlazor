using System.Collections.Generic;
using System.Text.Json.Serialization;
using LuckyBlazor.Model.Rating;

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
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("comments")]
        public IList<Comment> CommentList { get; set; }
        [JsonPropertyName("ratingPosts")]
        public IList<RatingPost> RatingPosts { get; set; }

        public Post()
        {
            
        }

        public Post(string content, int userId)
        {
            Content = content;
            UserId = userId;
        }
    }
}