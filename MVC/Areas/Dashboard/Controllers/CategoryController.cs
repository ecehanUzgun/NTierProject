using BLL.Services.Abstracts;
using BLL.Services.Concretes;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;

namespace MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService; //Neden?
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }

        //Create Category
        public IActionResult Create()
        {
            var category = new Category();
            
            return View(category);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            try
            { 
                _categoryService.CreateAsync(category);
                TempData["Success"] = "Kategori oluşturuldu.";
            }
            catch (Exception ex) 
            {
                TempData["Error"] = ex.Message;
            }
            return RedirectToAction("Index");   
        }

        //Update Category
        public IActionResult Update(int id) 
        { 
            var category = _categoryService.GetById(id);
            if (category != null)
            {
                return View(category);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category) 
        {
            try
            {
                await _categoryService.UpdateAsync(category);
                TempData["Success"] = "Kategori güncellendi";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
