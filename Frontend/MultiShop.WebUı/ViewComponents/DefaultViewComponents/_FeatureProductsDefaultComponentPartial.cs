using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ProductDtos;
using MultiShop.WebUı.Services.CatalogServices.ProductServices;
using Newtonsoft.Json;
using System.Net.Http;

namespace MultiShop.WebUı.ViewComponents.DefaultVievComponents
{
    public class _FeatureProductsDefaultComponentPartial :ViewComponent
    {
        private readonly IProductService _productService;
        public _FeatureProductsDefaultComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}
