using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _HeadUıLayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
