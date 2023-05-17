using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

    }
}
