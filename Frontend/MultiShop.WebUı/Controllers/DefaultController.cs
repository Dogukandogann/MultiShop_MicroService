using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
