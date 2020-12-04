using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum
{
    public class PostList
    {
        [JsonPropertyName("posts")]
        public IList<Post> Posts { get; set; }

        public int Size()
        {
            return Posts.Count;
        }

        public Post GetPost(int index)
        {
            return Posts[index];
        }
    }
    
}