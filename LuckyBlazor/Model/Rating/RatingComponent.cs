using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Rating
{
    public class RatingComponent
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("componentId")]
        public int componentId { get; set; }
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        [JsonPropertyName("score")]
        public int score { get; set; }

        public RatingComponent()
        {
            
        }

        public RatingComponent(int componentId, int userId, int score)
        {
            this.componentId = componentId;
            this.userId = userId;
            this.score = score;
        }
    }
}