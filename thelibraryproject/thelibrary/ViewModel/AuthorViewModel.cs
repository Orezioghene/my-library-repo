using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;

namespace thelibrary.ViewModel
{
    public class AuthorViewModel
    {
        [Key]
        public int Id { get; set; }

        //public IFormFile PictureURL { get; set; }
        //public string URL { get; set; }
        public string Name { get; set; }
        public string? Biography { get; set; }
        public sex Sex { get; set; }
    }
}
