using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.BasketServices;
using MultiShop.WebUı.Services.DiscountServices;

namespace MultiShop.WebUı.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public PartialViewResult ConfirmDiscountCoupon()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult ConfirmDiscountCoupon(string code)
        {
            code = "mrehaba";
            var values = _discountService.GetDiscountCode(code);
            return View(values);
        }
    }
}
