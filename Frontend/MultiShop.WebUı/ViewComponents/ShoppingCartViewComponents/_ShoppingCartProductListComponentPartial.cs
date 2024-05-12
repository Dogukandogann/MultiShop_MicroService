using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingCartProductListComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
