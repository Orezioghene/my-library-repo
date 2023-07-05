using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.Repository;

namespace thelibrary.Controllers
{
    public class CategoryController : Controller
    {

        private readonly LibraryDbContext _dbContext;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(LibraryDbContext dbContext, ICategoryRepository categoryRepository)
        {
            _dbContext = dbContext;
            this._categoryRepository = categoryRepository;

        }
        public async Task<IActionResult> Index()
        {
            var allCategories =await _dbContext.Categories.ToListAsync();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _categoryRepository.Add(category);
            return RedirectToAction("Index");

        }
    }
}
