using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.Data;

namespace thelibrary.Models
{
    public class SeatReservation
    {
        [Key]
        public int id { get; set; }
        public stat SeatStatus { get; set; }
        public DateTime Begins { get; set; } = DateTime.Now;
        public DateTime ExpiresOn { get; set; } 

        //Seat
        public int SeatId { get; set; }
        [ForeignKey("SeatId")]

        public Seat Seat { get; set; }

        //user
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
       

       
    }


}
