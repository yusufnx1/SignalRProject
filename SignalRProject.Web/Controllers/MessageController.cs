﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ClientUserCount()
        {
            return View();
        }
    }
}
