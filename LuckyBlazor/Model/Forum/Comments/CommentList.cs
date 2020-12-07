using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LuckyBlazor.Model.Forum
{
    public class CommentList
    {
        public IList<Comment> Comments { get; set; }
        
        
        public int Size()
        {
            return Comments.Count;
        }

        public Comment Get(int index)
        {
            return Comments[index];
        }
    }
    
    
}