using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.AboutDtos;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUı.Services.CatalogServices.AboutServices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace MultiShop.WebUı.ViewComponents.UıLayoutViewComponents
{
    public class _FooterUıLayoutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;
        public _FooterUıLayoutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAboutAsync();
            return View(values);
        }
    }
}
