using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.NewHelpers;
using thelibrary.Repository;
using thelibrary.ViewModel;

namespace thelibrary.Controllers
{
    public class ReviewController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly UserManager<Users> _userManager;
        private readonly IBookRepository _bookRepository;

        public ReviewController(LibraryDbContext dbContext,UserManager<Users> userManager,IBookRepository bookRepository)
        {
            _bookRepository= bookRepository;
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int bookId)
        {

            var book = await _dbContext.Books.
               FirstOrDefaultAsync(x => x.Id == bookId);
            //var book = await _dbContext.Books.FindAsync(bookId);
            if (book == null)
            {
                return NotFound();
            }

            var review = new Recommendation
            {
                BookId = bookId

            };

            return View(review);
        }
        //[Authorize]
        [HttpPost]        
        public async Task<IActionResult> Create(Recommendation review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var users = await _userManager.GetUserAsync(User);
                    //var users = await _userManager.FindByNameAsync(review.User.UserName);                 

                    
                    var users = await _userManager.FindByIdAsync(review.UserId.ToString());
                    var book = await _dbContext.Books.FindAsync(review.BookId);
                    
                    if (users != null && book != null)
                    {
                        review.User = users;
                        review.Book = book;
                        _dbContext.Recommendations.Add(review);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("Detail", "Book", new {id = review.BookId } );
                    }                  
                    

                }
                return View(review);
            }
            catch (Exception ex) { throw ex; }
            //var result = WebHelpers.CurrentUser.Email;
            

        }
    }
}

