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
        [JsonPropertyName("upVotes")]
        public int UpVotes { get; set; }
        [JsonPropertyName("downVotes")]
        public int DownVotes { get; set; }


        public override string ToString()
        {
            return Content;
        }
    }
}