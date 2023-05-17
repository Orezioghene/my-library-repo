using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.Data;

namespace thelibrary.Models
{
    public class SeatReservation
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Seat")]
        public int SeatId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public stat SeatStatus { get; set; }
        public DateTime On { get; set; } = DateTime.Now;
    }


}
