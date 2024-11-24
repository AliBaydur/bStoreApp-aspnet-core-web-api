using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Exceptions.BookNotFoundException;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool tracktChanges)
        {
            return await _manager.Category.GetAllCategoriesAsync(tracktChanges); 
        }

        public async Task<Category> GetOneCategoryByIdAsync(int id, bool tracktChanges)
        {
            var category =  await _manager.Category.GetOneCategoryByIdAsyn(id, tracktChanges);

            if (category == null) 
                throw new CategoryNotFoundException(id);

            return category;
        }
    }
}
