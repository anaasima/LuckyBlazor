using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model
{
    public class Build
    {
        [JsonPropertyName("id")]
        [Required]
        public int Id { get; set; }
        [JsonPropertyName("userId")]
        [Required]
        public int UserId { get; set; }
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        [JsonPropertyName("componentList")]
        [Required]
        public IList<Component> ComponentList { get; set; }

        public Build()
        {
            
        }

        public Build(IList<Component> components, int userId, string name)
        {
            ComponentList = components;
            UserId = userId;
            Name = name;
        }
        }
}