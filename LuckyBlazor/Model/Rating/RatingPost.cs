using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingPost
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("postId")]
        public int PostId { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }

        public RatingPost()
        {
            
        }

        public RatingPost(int userId, int postId, int score)
        {
            this.UserId = userId;
            this.PostId = postId;
            this.Score = score;
        }
    }
}