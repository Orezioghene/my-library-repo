using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.Services;
using thelibrary.ViewModel;

namespace thelibrary.Controllers
{
    public class AuthorController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPhotoService _photoService;
        public AuthorController(LibraryDbContext dbContext, IAuthorRepository authorRepository, IPhotoService photoService)
        {
            this._dbContext = dbContext;
            this._authorRepository = authorRepository;
            this._photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _authorRepository.GetAuthors();
            return View(data);
        }

        public async Task<IActionResult> UserIndex()
        {
            var data = await _authorRepository.GetAuthors();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            var model = new AuthorViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorViewModel author)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Upload Failed");
                return View(author);
            }

            //var result = await _photoService.AddPhotoAsync(author.PictureURL);

            var newAuthor = new Author()
            {
               Biography = author.Biography,
               Name = author.Name,
               Sex = author.Sex,
               //PictureURL = result.Url.ToString(),
               Id = author.Id
                
            };
            _authorRepository.Add(newAuthor);

          
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Edit(int Id)
        {
            var getauthor = await _authorRepository.GetById(Id);
            if (getauthor == null) return View("Error");
            var newAuthor = new AuthorViewModel()
            {
                Biography = getauthor.Biography,
                Name = getauthor.Name,
                Sex = getauthor.Sex,
                //PictureURL = result.Url.ToString(),
                Id = getauthor.Id
            };

            return View(newAuthor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Edit Failed");
                return View("Edit", model);
            }
            else
            {
                var author = await _authorRepository.GetById(model.Id);
                if (author != null)
                {
                    author.Id= model.Id;
                    author.Name = model.Name;
                    author.Biography = model.Biography;
                    author.Sex = model.Sex;

                    _authorRepository.Update(author);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }

            }

        }

        public IActionResult BookByAuthor(int Id)
        {
            var booksByAuthor = _dbContext.BookAuthors
            .Where(ba => ba.AuthorId == Id)
            .Include(ba => ba.Book)
            .ToList();
            //var author = _dbContext.BookAuthors.Include(c => c.Book).FirstOrDefault(c => c.Id == Id);
            return View(booksByAuthor);
        }

    }
}
