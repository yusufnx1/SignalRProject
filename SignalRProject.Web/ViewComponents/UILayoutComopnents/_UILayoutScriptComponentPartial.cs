using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.UILayoutComopnents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
