using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _NavbarUıLayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
