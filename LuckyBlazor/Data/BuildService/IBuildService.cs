using System.Collections.Generic;
using System.Threading.Tasks;
using LuckyBlazor.Model;

namespace LuckyBlazor.Data.BuildService
{
    public interface IBuildService
    {
        Task<IList<Build>> GetAllBuildsAsync(int userId);
        Task CreateBuild(Build build);
        Task EditBuild(Build build);
        Task DeleteBuild(int id);
    }
}