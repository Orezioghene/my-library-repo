using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using thelibrary.Data;
using thelibrary.Helpers;
using thelibrary.Models;
using thelibrary.ServicesResponse;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public class AuthenticationRepository : ServiceResponse,IAuthenticationRepository
    {
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<UserRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly LibraryDbContext _dbContext;
        public SignInManager<Users> _signInManager;

        public AuthenticationRepository(UserManager<Users> userManager,SignInManager<Users> signInManager,LibraryDbContext dbContext, RoleManager<UserRole> roleManager, IConfiguration configuration)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _dbContext = dbContext;
            _signInManager = signInManager;

        }
        public async Task<string> Login(LoginViewModel login)
        {
            var existUser = await _userManager.FindByNameAsync(login.Username);
            if (existUser != null && !existUser.IsDeleted)
            {               
                
                var result = await _signInManager.PasswordSignInAsync(existUser, login.Password,login.RememberMe,false);
                if (!result.Succeeded)
                {
                    await _userManager.AccessFailedAsync(existUser);
                    this.Results.Add(new ValidationResult("Username or password is incorrect"));
                    return null;
                }
                
                var userRoles = await _userManager.GetRolesAsync(existUser);                
                var role = userRoles.FirstOrDefault(x => x.Equals(RoleHelper.USER));              
                if(role == null)
                {
                    var getrole = await _roleManager.FindByNameAsync(RoleHelper.ADMIN);
                    await _roleManager.GetClaimsAsync(getrole);
                }
                var token = await CreateAuthenticationToken(existUser);
                existUser.LastLoginDate = DateTime.UtcNow;
                return token.Value;
            }
            this.Results.Add(new ValidationResult("Matric Number not found"));
            return login.ToString();            
        }

        private async Task<AuthenticationToken> CreateAuthenticationToken(Users existUser)
        {
            var Audiences = _configuration["JWT:ValidAudience"];
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]);

            var userRoles = await _userManager.GetRolesAsync(existUser);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                  {
                new(ClaimTypes.Name, existUser.UserName),
                new(ClaimTypes.Email, existUser.UserName),
               
                new(ClaimTypes.Role, userRoles.FirstOrDefault()),
                new(ClaimTypes.NameIdentifier, existUser.Id.ToString())
                  }),

                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["JWT:ValidIssuer"],
                Audience = _configuration["JWT:ValidAudience"],
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new AuthenticationToken()
            {
                Value = tokenHandler.WriteToken(token),
            };
        }

        public async Task<string> RegisterUser(RegisterViewModel model)
        {
            var userExist = await _userManager.FindByNameAsync(model.Name);            
            if (userExist != null)
            {
                this.Results.Add(new ValidationResult("User already exits"));
                return null;
            }
            var user = new Users()
            {
                Email = model.Email,
                UserName = model.Matric_No,
                Name = model.Name,
                Department = model.Department,
                UserType= model.UserType,                               
                CreatedBy = RoleHelper.ADMIN_ID().ToString(),
                SecurityStamp= Guid.NewGuid().ToString()
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                this.Results.Add(new ValidationResult("Registration failed"));
                return null;
            }
            else
            {
                await _userManager.AddToRoleAsync(user, "User");
                return model.ToString();
            }                     
            
        }

    }
}



