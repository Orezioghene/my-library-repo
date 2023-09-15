using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;

namespace thelibrary.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Password is required"),DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "UserType is required")]
        public usertype UserType { get; set; }

        [Required(ErrorMessage = "Matric_No is required")]
        public string Matric_No { get; set; }

        [Required(ErrorMessage = "Email is required"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}




