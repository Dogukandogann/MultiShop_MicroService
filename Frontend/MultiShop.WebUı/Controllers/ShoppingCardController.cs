using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.BasketDtos;
using MultiShop.WebUı.Services.BasketServices;
using MultiShop.WebUı.Services.CatalogServices.ProductServices;
using MultiShop.WebUı.Services.DiscountServices;

namespace MultiShop.WebUı.Controllers
{
    public class ShoppingCardController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;
        public ShoppingCardController(IProductService productService, IBasketService basketService)
        {
            _productService = productService;
            _basketService = basketService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Directory1 = "Ana Sayfa";
            ViewBag.Directory2 = "Ürünler";
            ViewBag.Directory2 = "Sepetim";
            var values = await _basketService.GetBasket();
            ViewBag.total = values.TotalPrice;
            var totalPriceWithTax = values.TotalPrice + values.TotalPrice / 100 * 10;
            var tax = values.TotalPrice / 100 * 10;
            ViewBag.Tax = tax;
            ViewBag.TotalPriceWithTax = totalPriceWithTax;
            return View();
        }

        public async Task<IActionResult> AddBasketItem(string id)
        {
            var product = await _productService.GetByIdProductAsync(id);
            if (product == null)
                return NotFound("Product not found");

            await _basketService.AddBasketItem(new BasketItemDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = 1,
                ProductImageUrl = product.ProductImageUrl
            });

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveBasketItem(string id)
        {
            await _basketService.RemoveBasketItem(id);
            return RedirectToAction("Index");
        }
    }
}
