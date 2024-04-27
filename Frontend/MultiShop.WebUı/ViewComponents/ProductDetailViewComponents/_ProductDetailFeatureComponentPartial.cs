using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailFeatureComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
