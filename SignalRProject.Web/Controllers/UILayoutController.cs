using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
