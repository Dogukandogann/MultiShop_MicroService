﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Areas.User.Controllers
{
    [Area("User")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
