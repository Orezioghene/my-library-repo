using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.Data;

namespace thelibrary.Models
{
    public class BookReservation
    {
        [Key]
        public int Resrvationid { get; set; }
        public stat BookStatus { get; set; }
        public DateTime Begins { get; set; } 
        public DateTime ExpiresOn { get; set; }

        //Book
        public int BookId { get; set; }        
        public Book Book { get; set; }

        //user
        public Guid UserId { get; set; }        
        public Users User { get; set; }

    }
}
