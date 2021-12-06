using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;

namespace MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category > 0
                    ? _productService.GetAllByCategoryId(category).Data
                    : _productService.GetAll().Data
            };
            return View(model);
        }
    }
}