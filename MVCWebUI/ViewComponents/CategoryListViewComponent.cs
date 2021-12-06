using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MVCWebUI.Models;

namespace MVCWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll().Data,
                ActiveCategoryId = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}