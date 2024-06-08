using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUı.Services.CatalogServices.CategoryServices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _NavbarUıLayoutComponentPartial :ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _NavbarUıLayoutComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}
