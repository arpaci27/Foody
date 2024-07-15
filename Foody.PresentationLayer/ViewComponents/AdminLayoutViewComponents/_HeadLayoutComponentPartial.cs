using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
