using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.Data;

namespace thelibrary.Models
{
    public class BorrowBook
    {
        [Key]
        public int BorrowId { get; set; }

        public DateTime BorrowDate { get; set; }= DateTime.Now;
        public DateTime ReturnDate { get; set; }
        //book
        public int BookId { get; set; }
        public Book Book { get; set; }
        //user
        public Guid UserId { get; set; }
        public Users User { get; set; }
        //public bool IsBorrowed { get; set; }






    }
}
