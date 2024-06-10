using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.BasketDtos;
using MultiShop.WebUı.Services.BasketServices;
using MultiShop.WebUı.Services.CatalogServices.ProductServices;

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
            var values = await _basketService.GetBasket();
            return View(values);
        }

        public async Task<IActionResult> AddBasketItem(string productId)
        {
            var product = await _productService.GetByIdProductAsync(productId);
            if (product == null)
                return NotFound("Product not found");

            await _basketService.AddBasketItem(new BasketItemDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = 1
            });

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveBasketItem(string productId)
        {
            await _basketService.RemoveBasketItem(productId);
            return RedirectToAction("Index");
        }
    }
}
