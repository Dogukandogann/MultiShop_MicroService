using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductListViewComponents
{
    public class _ProductListPaginationComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        
        }
    }
}
