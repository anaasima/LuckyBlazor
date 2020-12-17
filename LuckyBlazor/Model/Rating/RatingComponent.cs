using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingComponent
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("componentId")]
        public int ComponentId { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }

        public RatingComponent()
        {
            
        }

        public RatingComponent(int componentId, int userId, int score)
        {
            this.ComponentId = componentId;
            this.UserId = userId;
            this.Score = score;
        }
    }
}