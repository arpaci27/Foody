using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
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
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            var values = _categoryService.TGetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _categoryService.TGetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            var productValues = _productService.TGetById(id);
            return View(productValues);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductListWithCategory");
        }
    }
}
