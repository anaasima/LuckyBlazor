using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingPost
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        [JsonPropertyName("postId")]
        public int postId { get; set; }
        [JsonPropertyName("score")]
        public int score { get; set; }
    }
}