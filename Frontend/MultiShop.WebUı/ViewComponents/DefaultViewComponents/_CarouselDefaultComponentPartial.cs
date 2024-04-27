using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.DefaultVievComponents
{
    public class _CarouselDefaultComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
