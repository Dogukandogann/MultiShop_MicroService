using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUı.Services.CatalogServices.CategoryServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Category")]
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICategoryService _categoryService;

        public CategoryController(IHttpClientFactory httpClientFactory, ICategoryService categoryService)
        {
            _httpClientFactory = httpClientFactory;
            _categoryService = categoryService;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            CategoryViewbagList();
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
        [HttpGet]
        [Route("CreateCategory")]
        public IActionResult CreateCategory()
        {

            CategoryViewbagList();
            return View();
        }
        [HttpPost]
        [Route("CreateCategory")]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            try
            {
                await _categoryService.CreateCategoryAsync(createCategoryDto);
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            catch (Exception ex)
            {
                //logg gelebilir.
                return View();
            }
           
        }
        [Route("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            catch (Exception ex)
            {
                //logg
                return View();
            }           
        }
        [Route("UpdateCategory/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(string id)
        {
            try
            {
                CategoryViewbagList();
                var values = await _categoryService.GetByIdCategoryAsync(id);
                return View(values);

            }
            catch (Exception ex)
            {
                //logg
                return View();
            }

        }
        [Route("UpdateCategory/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            try
            {
                await _categoryService.UpdateCategoryAsync(updateCategoryDto);
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        void CategoryViewbagList()
        {
            ViewBag.v0 = "Kategori İşlemleri";
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Kategoriler";
            ViewBag.v3 = "Kategori Listesi";
        }
    }
}
