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
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        [JsonPropertyName("componentList")]
        [Required]
        public ComponentList ComponentList { get; set; }
        }
}