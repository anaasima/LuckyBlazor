using System.Threading.Tasks;
using LuckyBlazor.Model.Forum;

namespace LuckyBlazor.Data.ForumService
{
    public interface IForumService
    {
        Task<PostList> GetAllPosts();
    }
}