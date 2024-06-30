using Microsoft.AspNetCore.Mvc;

namespace MultiShop.RapidApiWebUı.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
