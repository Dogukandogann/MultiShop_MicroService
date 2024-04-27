using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductListViewComponents
{
    public class _ProductListComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
