using Microsoft.EntityFrameworkCore;
using System.Linq;
using thelibrary.Data;
using thelibrary.Map;
using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private LibraryDbContext _dbContext;
        public CategoryRepository(LibraryDbContext dbContext)
        {

            _dbContext = dbContext;

        }
        public bool Add(CategoryViewModel category)
        {
            
            var newCategory = new Category()
            {
                Name = category.Name,
            };

            _dbContext.Add(newCategory);
            return Save();
        }

        public bool Delete(Category category)
        {
            _dbContext.Remove(category);
            return Save();
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
        {

            var getCategory = await _dbContext.Categories.ToListAsync();
            return getCategory.Select(x => x.Map());
        }

        public async Task<Category> GetCategiryByName(string name)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<Category> GetCategoryById(int Id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.CategoryId == Id);
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Category category)
        {
            _dbContext.Update(category);
            return Save();
        }
    }
}
