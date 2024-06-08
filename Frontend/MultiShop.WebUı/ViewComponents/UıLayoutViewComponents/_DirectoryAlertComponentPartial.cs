using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _DirectoryAlertComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.Directory1 = "MultiShop";
            ViewBag.Directory2 = "Ana Sayfa";
            ViewBag.Directory2 = "Ürün Listesi";
            return View();
        }
    }
}
