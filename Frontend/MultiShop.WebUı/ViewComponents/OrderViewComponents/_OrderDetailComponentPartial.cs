using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.OrderViewComponents
{
    public class _OrderDetailComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
