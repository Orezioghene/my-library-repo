using System.ComponentModel.DataAnnotations.Schema;

namespace thelibrary.Models
{
    public class Recommendation
    {
        public int Id { get; set; }

        public string UserReview { get; set; }

        //Book
        public int BookId { get; set; }        
        public Book Book { get; set; }

        //User
        public Guid UserId { get; set; }        
        public Users User { get; set; }
       



    }
}
