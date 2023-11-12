using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using thelibrary.Data;
using thelibrary.Helpers;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.ServicesResponse;
using thelibrary.ViewModel;


namespace thelibrary.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<UserRole> _roleManager;
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IAuthenticationRepository _authenticationService;
        private readonly IConfiguration _configuration;        
        private readonly LibraryDbContext _dbContext;

        public AuthenticationController(UserManager<Users> userManager, IAuthenticationRepository authenticationService, LibraryDbContext dbContext, RoleManager<UserRole> roleManager, IConfiguration configuration)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _dbContext = dbContext;            
            _authenticationService = authenticationService;

        }
        public async Task<IActionResult> GetUsers()
        {
            var users = await _dbContext.Users.ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> Login()
        {
            var login = new LoginViewModel();
            return View(login);
        }
        public async Task<IActionResult> Register()
        {
            var register=  new RegisterViewModel();
            return View(register);
        }

        [HttpPost("Authentication/register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var result = await _authenticationService.RegisterUser(model);
            if (result == null)
                return StatusCode(StatusCodes.Status400BadRequest, new ResponseModel { Error = "Registration Failed", IsSuccessful = false });

            return RedirectToAction("Index", "Home");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _authenticationService.Login(model);
            if(result == null) 
                return StatusCode(StatusCodes.Status400BadRequest, new ResponseModel { Error = "Login Failed", IsSuccessful = false });

            else
            {
                if (model.Username == "eyiowuawibolutife@gmail.com")
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (User.IsInRole("User"))
                {
                    return RedirectToAction("UserIndex", "Book");
                }
                return RedirectToAction("UserIndex", "Book");
            }
        }        
    }
}
