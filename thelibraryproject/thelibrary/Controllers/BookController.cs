using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.Services;

namespace thelibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IBookRepository _bookRepository;
        private readonly IPhotoService _photoService;
        
        public BookController(LibraryDbContext dbContext, IBookRepository bookRepository,IPhotoService photoService)
        {
            _dbContext = dbContext;
            this._bookRepository = bookRepository;
            this._photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _bookRepository.GetBooks();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        //public IActionResult Detail(int Id)
        //{

        //}

        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel  model) 
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(model.ActualBook);
                var newBook = new Book()
                {
                    Title = model.Title,
                    Pages = model.Pages,
                    BookSummary = model.BookSummary,
                    ActualBook = result.Url.ToString(),
                    Category = new Category()
                    {
                        Name = model.Category.Name,
                    }
                };
                _bookRepository.Add(newBook);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Upload Failed");
            }

            return View(model);          
            

        }

        public async Task<IActionResult> Edit(int Id)
        {
            var getBook = await _bookRepository.GetBookById(Id);
            if (getBook == null) return View("Error");
            var bookVM = new EditBookViewModel
            {
                Title = getBook.Title,
                BookSummary = getBook.BookSummary,
                Pages = getBook.Pages,
                ActualBook = getBook.ActualBook,
                Category = new CategoryViewModel()
                {
                    Name = getBook.Category.Name,
                }

            };
            return View(bookVM);

        }
    }
}
