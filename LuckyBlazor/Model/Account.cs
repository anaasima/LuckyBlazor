using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model
{
    public class Account
    {
        [JsonPropertyName("userid")]
        [Required]
        public int UserId { get; set; }
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        [JsonPropertyName("username")]
        [Required]
        public string Username
        {
            get;
            set;
        }
        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }

}
}