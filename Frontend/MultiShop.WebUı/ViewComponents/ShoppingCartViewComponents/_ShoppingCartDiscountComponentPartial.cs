using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingCartDiscountComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
