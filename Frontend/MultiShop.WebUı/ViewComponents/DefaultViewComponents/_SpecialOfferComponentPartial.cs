using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.DefaultVievComponents
{
    public class _SpecialOfferComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
