using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
