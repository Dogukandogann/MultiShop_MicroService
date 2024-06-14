using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.OrderViewComponents
{
    public class _OrderSummaryComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
