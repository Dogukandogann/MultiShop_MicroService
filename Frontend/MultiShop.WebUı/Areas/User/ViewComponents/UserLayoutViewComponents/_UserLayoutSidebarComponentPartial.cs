using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Areas.User.ViewComponents.UserLayoutViewComponents
{
    public class _UserLayoutSidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
