using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string BookSummary { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }


    }
}
