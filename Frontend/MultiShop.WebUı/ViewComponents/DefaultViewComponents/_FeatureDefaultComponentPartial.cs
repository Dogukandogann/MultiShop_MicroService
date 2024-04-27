using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.DefaultVievComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
