using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingBuild
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("buildId")]
        public int BuildId { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }

        public RatingBuild()
        {
            
        }

        public RatingBuild(int buildId, int userId, int score)
        {
            this.BuildId = buildId;
            this.UserId = userId;
            this.Score = score;
        }
    }
}