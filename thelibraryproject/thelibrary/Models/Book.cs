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
        public string ActualBook { get; set; }


        [ForeignKey("Category")]
        //category
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }

        //recommendations

        public ICollection<Recommendation> Recommendations { get; set; }

        //Author

        public ICollection<BookAuthor> BookAuthors { get; set; }

        //Borrow book

        public ICollection<BorrowBook> BookBorrowers { get; set; }





    }
}
