using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;

namespace thelibrary.Controllers
{
    public class ReservationController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly UserManager<Users> _userManager;
        public ReservationController(LibraryDbContext dbContext,UserManager<Users> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }

        

        

    }
}
