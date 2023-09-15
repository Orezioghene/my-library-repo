using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Repository;

namespace thelibrary.Controllers
{
    public class SeatController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly ISeatRepository _seatRepository;

        public SeatController(LibraryDbContext dbContext, ISeatRepository seatRepository)
        {
            _dbContext = dbContext;
            _seatRepository= seatRepository;
        }
        public async Task<IActionResult> Index()
        {
            var allSeats = await _seatRepository.GetAllSeat();
            return View(allSeats);
        }
    }
}
