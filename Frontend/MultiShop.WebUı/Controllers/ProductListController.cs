﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.i=id;
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
