using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;

namespace MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll().Data
            };
            return View(model);
        }
    }
}