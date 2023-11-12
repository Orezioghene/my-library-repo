using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net;
using thelibrary.Data;
using thelibrary.Map;
using thelibrary.Migrations;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.Services;
using thelibrary.ViewModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace thelibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPhotoService _photoService;
        private readonly IAuthorRepository _authorRepository;
        private readonly UserManager<Users> _userManager;

        public BookController(LibraryDbContext dbContext, UserManager<Users> userManager, IAuthorRepository authorRepository, IBookRepository bookRepository, IPhotoService photoService, ICategoryRepository categoryRepository)
        {
            this._dbContext = dbContext;
            this._bookRepository = bookRepository;
            this._photoService = photoService;
            this._categoryRepository = categoryRepository;
            this._authorRepository = authorRepository;
            this._userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            
            var data = _bookRepository.GetBooks();
                return View(data);                      
            
        }

        public async Task<IActionResult> UserIndex()
        {

            var data = _bookRepository.GetBooks();
            return View(data);

        }

        public IActionResult Search(string searchTerm)
        {
            var books = _dbContext.Books
                .Where(b => b.Title.Contains(searchTerm) || b.Category.Name.Contains(searchTerm))
                .ToList();

            return View("SearchResults", books);
        }


        public async Task<IActionResult> GetUserId()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetUserId(string username)
        {
            
                var user = await _userManager.FindByNameAsync(username);

                if (user != null)
                {
                    ViewBag.UserId = user.Id;
                }
                else
                {
                    ViewBag.UserId = null; // User not found
                }

                return View(); // Return to the same form view
            
        }
        public async Task<IActionResult> Detail(int Id)
        {
            var getBook = await _bookRepository.GetBookById(Id);
            return View(getBook);
        }       

        public async Task<IActionResult> Create()
        {
            var model =  new BookViewModel();
            
            var categories = await _categoryRepository.GetAllCategories();
            var authors = await _authorRepository.GetAuthors();
            ViewBag.category = new SelectList(categories.ToList(), "Id", "Name");
            ViewBag.author = new MultiSelectList(authors.ToList(), "Id", "Name");


            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel  model) 
        {
           
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Upload Failed"); 
                return View(model);
            }
            
            var result = await _photoService.AddPhotoAsync(model.ActualBook);

            var newBook = new Book()
            {
                Title = model.Title,
                Pages = model.Pages,
                BookSummary = model.BookSummary,
                ActualBook = result.Url.ToString(),
                CategoryId = model.CategoryId,
                
                
            };
            _bookRepository.Add(newBook);
            //_dbContext.SaveChanges();

            foreach (var id in model.AuthorId)
            {
                var _book_author = new BookAuthor()
                {
                    BookId = newBook.Id,
                    AuthorId = id
                };
                _dbContext.BookAuthors.Add(_book_author);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
                                        
            

        }
        //[Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Edit(int Id)
        {
            var getBook = await _bookRepository.GetBookById(Id);
            if (getBook == null) return View("Error");
            var categories = await _categoryRepository.GetAllCategories();
            var authors = await _authorRepository.GetAuthors();
            ViewBag.category = new SelectList(categories.ToList(), "Id", "Name");
            ViewBag.author = new MultiSelectList(authors.ToList(), "Id", "Name");
            var bookVM = getBook.Mapper();            
            return View(bookVM);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditBookViewModel model, int Id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Edit Failed");
                return View("Edit", model);
            }
            else
            {
                var book = await _bookRepository.GetBookById(Id);
                if (book != null)
                {
                    try
                    {

                        await _photoService.DeletePhotoAsync(book.ActualBook);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Couldn't Delete photos");
                        return View(model);
                    }
                    var photoresult = await _photoService.AddPhotoAsync(model.ActualBook);

                    book.Id = model.Id;
                    book.Title = model.Title;
                    book.Pages = model.Pages;
                    book.BookSummary = model.BookSummary;
                    book.ActualBook = photoresult.Url.ToString();
                    book.CategoryId = model.CategoryId;

                    if(model.AuthorId != null)
                    {
                        foreach (var id in model.AuthorId)
                        {
                            var _book_author = new BookAuthor()
                            {
                                BookId = book.Id,
                                AuthorId = id
                            };
                            _dbContext.BookAuthors.Add(_book_author);
                            _dbContext.SaveChanges();
                        }

                    }
                    _dbContext.SaveChanges();
                    _bookRepository.Update(book);                  
                    return RedirectToAction("Index");
                    }
                else
                {
                    return View(model);
                }

            }            

        }
        public async Task<IActionResult> Borrow(int bookId)
        {
            var book = await _dbContext.BookReservations.
                Include(r => r.Book).
                Include(r => r.User).
                FirstOrDefaultAsync(x => x.BookId == bookId);
            //var book = await _dbContext.Books.FirstOrDefaultAsync(b=>b.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }

            var Borrow = new BorrowBook
            {
                BookId = bookId,
                
            };

            return View(Borrow);
            
        }

        [HttpPost]
        public async Task<IActionResult> Borrow(BorrowBook borrow)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == borrow.BookId);
            var reservation = _dbContext.BookReservations
            .Include(r => r.User) // Include the user information
            .FirstOrDefault(r => r.BookId == borrow.BookId);


            if (book != null && book.IsReserved== true)
            {

                var borrowedbook = new BorrowBook
                {
                    BookId = borrow.BookId,
                    UserId = reservation.UserId, // Replace with actual user name
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(14)
                };

                book.IsReserved = true;
                book.IsBorrowed = true;
                _dbContext.Booksborrowed.Add(borrowedbook);  
                _dbContext.SaveChanges();
               

               
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Return(BorrowBook borrow)
        {
            var borrowed = await _dbContext.Booksborrowed.FirstOrDefaultAsync(x => x.BookId == borrow.BookId);
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == borrowed.BookId);

            if (borrowed != null && book.IsBorrowed == true )
            {
                
                if (book != null)
                {
                    book.IsReserved = false;
                    book.IsBorrowed = false;
                    //_dbContext.Booksborrowed.Remove(borrow);
                    _dbContext.SaveChanges();


                }                
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Reserve(int bookId)
        {

            var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == bookId);            
            if (book == null)
            {
                return NotFound();
            }

            var reservation = new BookReservation
            {
                BookId = bookId

            };

            return View(reservation);
        }
        [HttpPost]
        public async Task<ActionResult> Reserve(BookReservation reservation)
        {
            if (ModelState.IsValid)
            {
                var users = await _userManager.FindByIdAsync(reservation.UserId.ToString());
                var book = await _dbContext.Books.FindAsync(reservation.BookId);

                if (book != null && !book.IsReserved)
                {
                    // Create a new reservation
                    var newreservation = new BookReservation
                    {
                        BookId = reservation.BookId,
                        UserId = reservation.UserId,
                        Begins = DateTime.Now,
                        ExpiresOn = DateTime.Now.AddDays(3)
                    };

                    // Update the book to mark it as reserved
                    book.IsReserved= true;

                    _dbContext.BookReservations.Add(newreservation);
                    _dbContext.SaveChanges();

                    TempData["ReservationSuccess"] = "Reservation successful!";
                    return RedirectToAction("Detail", "Book", new { Id = newreservation.BookId });
                }
                else
                {
                    TempData["ReservationError"] = "The book is not available for reservation.";
                    return View(reservation);
                }   
            }
            
            else
            {
                TempData["ReservationError"] = "The book is not available for reservation.";
                return View(reservation);
            }

            
        }

        public ActionResult Cancel(BookReservation reservation)
        {
            var cancel_reservation = _dbContext.BookReservations.FirstOrDefault(r => r.Resrvationid == reservation.Resrvationid);

            if (reservation != null)
            {
                var book = _dbContext.Books.FirstOrDefault(b => b.Id == reservation.BookId);
                if (book != null)
                {
                    // Update the book to mark it as available
                    book.IsReserved = false;
                }

                _dbContext.BookReservations.Remove(reservation);
                _dbContext.SaveChanges();

                TempData["CancellationSuccess"] = "Reservation canceled successfully!";
            }
            else
            {
                TempData["CancellationError"] = "The reservation could not be found.";
            }

            return RedirectToAction("Index");
        }

        public void CheckAndCancelExpiredReservations()
        {
            var now = DateTime.Now;
            var expiredReservations = _dbContext.BookReservations
                .Where(r => r.ExpiresOn < now)
                .ToList();

            foreach (var reservation in expiredReservations)
            {
                var book = _dbContext.Books.FirstOrDefault(b => b.Id == reservation.BookId);
                if (book != null)
                {
                    // Update the book to mark it as available
                    book.IsReserved = false;                    
                    _dbContext.SaveChanges();
                }               
            }           
        }

        public async Task<IActionResult> Reservations()
        {
            var reservations = await _dbContext.BookReservations.Where(r => r.Book.IsReserved).Include(r => r.User).Include(r=>r.Book)
            .ToListAsync();
            return View(reservations);




        }
    }
}


