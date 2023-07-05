using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;

namespace thelibrary.Controllers
{
    public class SeatController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        public SeatController(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allSeats = await _dbContext.Seats.ToListAsync();
            return View();
        }
    }
}
