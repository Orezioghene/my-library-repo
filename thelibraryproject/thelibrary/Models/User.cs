using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;

namespace thelibrary.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }
        public usertype UserType { get; set; }
        public string? Matric_No { get; set; }

    }
}
