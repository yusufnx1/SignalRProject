using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.LayoutComponents
{
	public class _LayoutHeaderPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
