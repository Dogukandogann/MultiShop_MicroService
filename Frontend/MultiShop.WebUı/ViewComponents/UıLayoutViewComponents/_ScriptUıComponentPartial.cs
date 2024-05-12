using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _ScriptUıComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
