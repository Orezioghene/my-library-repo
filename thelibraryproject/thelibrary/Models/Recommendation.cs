using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class Recommendation
    {
        public int Id { get; set; }

        public string UserReview { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("User")]
        public int  UserId { get; set; }



    }
}
