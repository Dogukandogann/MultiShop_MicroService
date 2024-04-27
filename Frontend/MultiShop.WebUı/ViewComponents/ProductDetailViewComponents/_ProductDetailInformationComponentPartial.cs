using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailInformationComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
