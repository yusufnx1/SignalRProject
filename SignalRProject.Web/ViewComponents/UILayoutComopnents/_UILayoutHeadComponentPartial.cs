using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.UILayoutComopnents
{
    public class _UILayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
