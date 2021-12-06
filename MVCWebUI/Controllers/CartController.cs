using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Helpers;
using MVCWebUI.Models;

namespace MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper,
            IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productResult = _productService.GetById(productId);
            if (!productResult.Success) return RedirectToAction("Index", "Product");

            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(cart, productResult.Data);
            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", $"{productResult.Data.ProductName} has been added to cart.");

            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var productResult = _productService.GetById(productId);
            if (!productResult.Success) return RedirectToAction("Index", "Cart");

            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFromCart(cart, productResult.Data.ProductId);
            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", $"{productResult.Data.ProductName} has been deleted to cart.");

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid) return View();
            //
            TempData.Add("message", "Your order has been created.");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }
    }
}