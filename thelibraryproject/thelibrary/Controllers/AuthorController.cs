using Microsoft.AspNetCore.Mvc;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.Repository;

namespace thelibrary.Controllers
{
    public class AuthorController : Controller
    {
        private readonly LibraryDbContext _dbContext;
        private readonly IAuthorRepository _authorRepository;
        public AuthorController(LibraryDbContext dbContext, IAuthorRepository authorRepository )
        {
            _dbContext = dbContext;
            this._authorRepository = authorRepository;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _authorRepository.GetAuthors();
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorViewModel author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            _authorRepository.Add(author);
            return RedirectToAction("Index");

        }
    }
}
