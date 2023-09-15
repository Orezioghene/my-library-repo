using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Map;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.Services;
using thelibrary.ViewModel;

namespace thelibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPhotoService _photoService;
        private readonly IAuthorRepository _authorRepository;

        public BookController(LibraryDbContext dbContext, IAuthorRepository authorRepository, IBookRepository bookRepository, IPhotoService photoService, ICategoryRepository categoryRepository)
        {
            this._dbContext = dbContext;
            this._bookRepository = bookRepository;
            this._photoService = photoService;
            this._categoryRepository = categoryRepository;
            this._authorRepository = authorRepository;

        }

        public async Task<IActionResult> Index()
        {
            var data =  _bookRepository.GetBooks();
            return View(data);
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

        public async Task<IActionResult> Edit(int Id)
        {
            var getBook = await _bookRepository.GetBookById(Id);
            if (getBook == null) return View("Error");
            var categories = await _categoryRepository.GetAllCategories();
            ViewBag.category = new SelectList(categories.ToList(), "Id", "Name");
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
                    //book.CatgoryList = model.CatgoryList;                    

                    _bookRepository.Update(book);

                  
                    return RedirectToAction("Index");
                    }
                else
                {
                    return View(model);
                }

            }
            

        }
    }
}
