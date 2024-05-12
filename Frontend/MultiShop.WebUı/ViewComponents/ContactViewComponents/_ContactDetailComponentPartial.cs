using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ContactViewComponents
{
    public class _ContactDetailComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
