using System.ComponentModel.DataAnnotations;

namespace thelibrary.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public string position { get; set; }
    }
}
