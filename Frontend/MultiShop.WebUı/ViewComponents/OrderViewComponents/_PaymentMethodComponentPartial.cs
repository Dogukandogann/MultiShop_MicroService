using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.OrderViewComponents
{
    public class _PaymentMethodComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
