using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LuckyBlazor.Model.Forum;

namespace LuckyBlazor.Model
{
    public class Account
    {
        [JsonPropertyName("id")]
        [Required]
        public int UserId { get; set; }

        [JsonPropertyName("name")] [Required] 
        public string Name { get; set; }

        [JsonPropertyName("username")]
        [Required]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }
        
        [JsonPropertyName("posts")]
        public IList<Post> PostList { get; set; }
        [JsonPropertyName("savedPosts")]
        public IList<Post> SavedPosts { get; set; }
        [JsonPropertyName("followedAccounts")]
        public IList<Account> FollowedAcounts { get; set; }
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Account(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }

        public Account()
        {
            
        }

        public Account(int id, string username, string password, string name)
        {
            UserId = id;
            Username = username;
            Password = password;
            Name = name;
        }
    }
}