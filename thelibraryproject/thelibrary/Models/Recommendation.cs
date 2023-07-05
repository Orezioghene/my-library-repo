using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class Recommendation
    {
        public int Id { get; set; }

        public string UserReview { get; set; }

        //Book
        public int BookId { get; set; }
        [ForeignKey("BookId")]

        public Book Book { get; set; }

        //User
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
       



    }
}
