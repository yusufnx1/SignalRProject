using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
