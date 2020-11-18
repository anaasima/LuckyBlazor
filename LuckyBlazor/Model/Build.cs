using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model
{
    public class Build
    {
        [JsonPropertyName("id")]
        [Required]
        public int Id { get; set; }
        [JsonPropertyName("userid")]
        [Required]
        public int UserId { get; set; }
        [JsonPropertyName("type")]
        [Required]
        public string Type { get; set; }
        [JsonPropertyName("brand")]
        [Required]
        public string Brand { get; set; }
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        [JsonPropertyName("releaseYear")]
        [Required]
        public int ReleaseYear { get; set; }
        [JsonPropertyName("additionalInformation")]
        [Required]
        public string AdditionalInformation { get; set; }
        
    }
}