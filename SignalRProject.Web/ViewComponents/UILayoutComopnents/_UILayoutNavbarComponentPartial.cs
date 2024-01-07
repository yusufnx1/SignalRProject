using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.UILayoutComopnents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
