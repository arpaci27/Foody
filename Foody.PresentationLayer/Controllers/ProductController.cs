using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductList()
        {
            var products = _productService.TGetAll();
            return View(products);
        }
        public IActionResult ProductListWithCategory()
        {
            var products = _productService.TProductListWithCateory();
            return View(products);
        }
    }
}
