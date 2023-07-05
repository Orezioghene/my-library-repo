using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace thelibrary.Models
{
    public class EditBookViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string BookSummary { get; set; }
        public string ActualBook { get; set; }
        [ForeignKey("Category")]
        //category
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }

    }
}
