using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model
{
    public class Component
    {
        [JsonPropertyName("id")]
        [Required]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        
        [JsonPropertyName("type")]
        [Required]
        public string Type { get; set; }
        
        [JsonPropertyName("releaseYear")]
        [Required]
        public string ReleaseYear { get; set; }
        
        [JsonPropertyName("brand")]
        [Required]
        public string Brand { get; set; }
        
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    }
}