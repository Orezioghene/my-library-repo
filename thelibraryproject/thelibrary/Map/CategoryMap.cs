using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Map
{
    public static class CategoryMap
    {
        public static CategoryViewModel Map(this Category model)
        {
            if (model == null)
            {
                return null;
            }
            return new CategoryViewModel
            {
                Id = model.CategoryId,
                Name = model.Name
            };
        }

        public static Category Map(this CategoryViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Category
            {
                CategoryId = model.Id,
                Name = model.Name
            };
        }
    }
}
