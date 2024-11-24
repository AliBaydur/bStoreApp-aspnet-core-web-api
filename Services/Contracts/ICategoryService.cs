using Entities.Models;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync(bool tracktChanges);
        Task<Category> GetOneCategoryByIdAsync(int id, bool tracktChanges);
    }
}
