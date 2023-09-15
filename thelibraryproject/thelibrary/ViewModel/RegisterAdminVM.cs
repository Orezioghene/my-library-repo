using System.ComponentModel.DataAnnotations;

namespace thelibrary.ViewModel
{
    public class RegisterAdminVM
    {

        [Required(ErrorMessage = "UserName is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}

