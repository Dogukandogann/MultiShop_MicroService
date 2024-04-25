using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _TopbarUıLayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
