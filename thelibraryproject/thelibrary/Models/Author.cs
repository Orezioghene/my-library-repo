using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;

namespace thelibrary.Models
{
    public class Author
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string? Biography { get; set; }
        public sex Sex { get; set; }


    }
}
