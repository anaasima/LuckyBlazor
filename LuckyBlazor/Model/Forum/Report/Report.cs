using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum.Report
{
    public class Report
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        [JsonPropertyName("postId")]
        public int postId { get; set; }

        public Report()
        {
            
        }

        public Report(int userId, int postId)
        {
            this.userId = userId;
            this.postId = postId;
        }
    }
}