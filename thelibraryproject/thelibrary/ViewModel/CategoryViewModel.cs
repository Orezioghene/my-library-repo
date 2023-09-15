using thelibrary.Models;

namespace thelibrary.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public List<Category> Categories { get; set; } = new List<Category>();


        public static explicit operator CategoryViewModel(Category source)
        {
            var destination = new CategoryViewModel()
            {
                Id = source.CategoryId,
                Name = source.Name,
            };
            return destination;
        }

        public static explicit operator Category(CategoryViewModel source)
        {
            var destination = new Category()
            {
                CategoryId = source.Id,
                Name = source.Name,
            };
            return destination;
        }

        
    }

   

}
