using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }

        //Author
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]

        public Author Author { get; set; }

        //Book
        public int BookId { get; set; }
        [ForeignKey("BookId")]

        public Book Book { get; set; }
       

    }
}
