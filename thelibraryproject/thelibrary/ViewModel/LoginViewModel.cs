using System.ComponentModel.DataAnnotations;

namespace thelibrary.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool RememberMe { get; internal set; }
    }
}
