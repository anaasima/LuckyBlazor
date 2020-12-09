using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingBuild
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("buildId")]
        public int buildId { get; set; }
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        [JsonPropertyName("score")]
        public int score { get; set; }

        public RatingBuild()
        {
            
        }

        public RatingBuild(int buildId, int userId, int score)
        {
            this.buildId = buildId;
            this.userId = userId;
            this.score = score;
        }
    }
}