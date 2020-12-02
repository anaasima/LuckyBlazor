using System.Collections.Generic;

namespace LuckyBlazor.Model.Forum
{
    public class PostList
    {
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