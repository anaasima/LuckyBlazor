using System.Collections.Generic;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Rating;

namespace LuckyBlazor.Data.BuildService
{
    public interface IBuildService
    {
        Task<IList<Build>> GetAllBuildsAsync(int userId);
        Task CreateBuild(Build build);
        Task EditBuild(Build build);
        Task DeleteBuild(int id);
        Task LeaveRating(RatingBuild ratingBuild);

        Task<IList<RatingBuild>> GetAllBuildRatings(int id);
    }
}