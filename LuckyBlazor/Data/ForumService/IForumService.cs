using System.Collections.Generic;
using System.Threading.Tasks;
using LuckyBlazor.Model.Forum;
using LuckyBlazor.Model.Forum.Report;
using LuckyBlazor.Model.Rating;

namespace LuckyBlazor.Data.ForumService
{
    public interface IForumService
    {
        Task<IList<Post>> GetAllPosts();
        Task<IList<Post>> GetPostsByUserId(int userId);
        Task CreatePost(Post post);
        Task RatePost(RatingPost ratingPost);
        Task CreateComment(Comment comment);
        Task SavePosts(Post post, int userId);
        Task<IList<Post>> GetSavedPosts(int userId);
        Task DeletePost(int id);
        Task ReportPost(Report report);
        Task DeleteReport(int id);
        Task<IList<Report>> GetReports();

        Task EditPost(Post post);

    }
}