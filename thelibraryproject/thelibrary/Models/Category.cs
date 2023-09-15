using System.ComponentModel.DataAnnotations;

namespace thelibrary.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //books

        public ICollection<Book> Books { get; set; }
    }
}

