using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using thelibrary.Data;
using thelibrary.Map;
using thelibrary.Models;
using thelibrary.Repository;
using thelibrary.ViewModel;

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
            return View(allCategories);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var allCategories = await _dbContext.Categories.ToListAsync();
            return View(allCategories);
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
            else
            {
                var exist = _dbContext.Set<Category>().Where(c => c.Name == category.Name).FirstOrDefault();
                if(exist != null)
                {
                    return View("Error");
                }

                _categoryRepository.Add(category);
                return RedirectToAction("Index");
            }      
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var getcategory = await _categoryRepository.GetCategoryById(Id);
            if (getcategory == null) return View("Error");
            
            return View(getcategory);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Edit Failed");
                return View("Edit", model);
            }
            else
            {
                var acategory  = await _categoryRepository.GetCategoryById(model.Id);
                if (acategory != null)
                {
                    acategory.CategoryId= model.Id;
                    acategory.Name = model.Name;               
                    
                    _categoryRepository.Update(acategory);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }

            }

        }

        public IActionResult BooksByCategory(int CategoryId)
        {
            var category = _dbContext.Categories.Include(c => c.Books).FirstOrDefault(c => c.CategoryId == CategoryId);
            return View(category);
        }


    }
}
