using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.BasketServices;
using MultiShop.WebUı.Services.DiscountServices;

namespace MultiShop.WebUı.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;
        private readonly IBasketService _basketService;

        public DiscountController(IDiscountService discountService, IBasketService basketService)
        {
            _discountService = discountService;
            _basketService = basketService;
        }
        [HttpGet]
        public PartialViewResult ConfirmDiscountCoupon()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmDiscountCoupon(string code)
        {
            var values =  await _discountService.GetDiscountCode(code);
            var basketValues = await _basketService.GetBasket();
            var totalPriceWithTax = basketValues.TotalPrice + basketValues.TotalPrice / 100 * 10;
            var TotalPriceWithDiscount = totalPriceWithTax - (totalPriceWithTax / 100 * values.Rate);
            return RedirectToAction("Index","ShoppingCard",new {code=code,discountRate=values.Rate,newPrice= TotalPriceWithDiscount });
        }
    }
}
