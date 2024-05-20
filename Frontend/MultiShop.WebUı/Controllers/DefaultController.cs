using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var user = User.Claims;
            int x;
            return View();
        }
    }
}
