using Foody.BusinessLayer.Abstract;
using Foody.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;
		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult CategoryList()
		{
			var values = _categoryService.TGetAll();
			return View(values);
		}
	}
}
