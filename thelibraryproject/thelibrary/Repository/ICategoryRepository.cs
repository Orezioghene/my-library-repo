using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryViewModel>> GetAllCategories();

        Task<Category> GetCategiryByName(string name);
        Task<Category> GetCategoryById(int Id);

        bool Add(CategoryViewModel category);
        bool Delete(Category category);
        bool Update(Category category);
        bool Save();
    }
}
