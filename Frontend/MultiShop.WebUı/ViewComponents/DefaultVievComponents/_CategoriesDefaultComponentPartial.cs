﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.DefaultVievComponents
{
    public class _CategoriesDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
