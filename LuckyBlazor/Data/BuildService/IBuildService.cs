using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.BuildService
{
    public interface IBuildService
    {
        Task<BuildList> GetAllBuildsAsync(int userId);
        Task CreateBuild(Build build);
        Task EditBuild(Build build);
        Task DeleteBuild(int id);
    }
}