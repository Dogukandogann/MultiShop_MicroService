using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.OfferDiscountDtos;
using MultiShop.WebUı.Services.CatalogServices.OfferDiscountServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/DiscountOffer")]
    public class DiscountOfferController : Controller
    {
        private readonly IOfferDiscountService _offerDiscountService;
        public DiscountOfferController(IOfferDiscountService offerDiscountService)
        {
            _offerDiscountService = offerDiscountService;
        }
        void OfferDiscountViewBagList()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "İndirim Teklifleri";
            ViewBag.v3 = "İndirim Teklif Listesi";
            ViewBag.v0 = "İndirim Teklif İşlemleri";
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            OfferDiscountViewBagList();
            var values = await _offerDiscountService.GetAllOfferDiscountAsync();
            return View(values);
        }

        [HttpGet]
        [Route("CreateDiscountOffer")]
        public IActionResult CreateDiscountOffer()
        {
            OfferDiscountViewBagList();
            return View();
        }

        [HttpPost]
        [Route("CreateDiscountOffer")]
        public async Task<IActionResult> CreateDiscountOffer(CreateOfferDiscountDto createOfferDiscountDto)
        {
            await _offerDiscountService.CreateOfferDiscountAsync(createOfferDiscountDto);
            return RedirectToAction("Index", "DiscountOffer", new { area = "Admin" });
        }

        [Route("DeleteDiscountOffer/{id}")]
        public async Task<IActionResult> DeleteDiscountOffer(string id)
        {
            await _offerDiscountService.DeleteOfferDiscountAsync(id);
            return RedirectToAction("Index", "DiscountOffer", new { area = "Admin" });
        }

        [Route("UpdateDiscountOffer/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateDiscountOffer(string id)
        {
            OfferDiscountViewBagList();
            var values = await _offerDiscountService.GetByIdOfferDiscountAsync(id);
            return View(values);
        }
        [Route("UpdateDiscountOffer/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateDiscountOffer(UpdateOfferDiscountDto updateOfferDiscountDto)
        {
            await _offerDiscountService.UpdateOfferDiscountAsync(updateOfferDiscountDto);
            return RedirectToAction("Index", "DiscountOffer", new { area = "Admin" });
        }
    }
}
