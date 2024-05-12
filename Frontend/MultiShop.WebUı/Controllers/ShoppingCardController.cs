using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Controllers
{
    public class ShoppingCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
