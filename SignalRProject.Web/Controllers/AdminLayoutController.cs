﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
