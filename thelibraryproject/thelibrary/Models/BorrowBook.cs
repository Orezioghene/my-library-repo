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
        public stat BookStatus { get; set; }

        //book
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }

        //user
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
        
       




    }
}
