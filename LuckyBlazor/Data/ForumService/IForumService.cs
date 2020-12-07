using System.Collections.Generic;
using System.Threading.Tasks;
using LuckyBlazor.Model.Forum;

namespace LuckyBlazor.Data.ForumService
{
    public interface IForumService
    {
        Task<IList<Post>> GetAllPosts();
        Task<IList<Post>> GetPostsByUserId(int userId);
        Task CreatePost(Post post);
    }
}