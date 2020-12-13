using System.Collections.Generic;
using System.Threading.Tasks;
using LuckyBlazor.Model;
using LuckyBlazor.Model.Rating;

namespace LuckyBlazor.Data
{
    public interface IComponentService
    {
        Task<IList<Component>> GetAllComponentsAsync();

        Task AddNewComponentAsync(Component component);
        Task RateComponent(RatingComponent ratingComponent);
    }
}