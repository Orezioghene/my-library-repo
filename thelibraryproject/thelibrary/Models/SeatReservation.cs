using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.Data;

namespace thelibrary.Models
{
    public class SeatReservation
    {
        [Key]
        public int Id { get; set; }
        public stat SeatStatus { get; set; }
        public string position { get; set; }
        public DateTime Begins { get; set; } = DateTime.Now;
        public DateTime ExpiresOn { get; set; } 

        //Seat
        public int SeatId { get; set; }    

        public Seat Seat { get; set; }

        //user
        public Guid UserId { get; set; }
        public Users User { get; set; }
       

       
    }


}
