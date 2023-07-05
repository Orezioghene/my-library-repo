using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;

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

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategiryByName(string name)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<Category> GetCategoryById(int Id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == Id);
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
