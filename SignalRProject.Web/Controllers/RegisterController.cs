using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.Entities.Entities;
using SignalRProject.Web.Dto.IdentityDto;

namespace SignalRProject.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            var appuser = new AppUser()
            {
                Name = registerDto.Name,
                Surname = registerDto.Surname,
                UserName = registerDto.Username,
                Email = registerDto.Mail
            };
            var result = await _userManager.CreateAsync(appuser, registerDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
