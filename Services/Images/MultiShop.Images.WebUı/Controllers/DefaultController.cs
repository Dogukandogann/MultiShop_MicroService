using Microsoft.AspNetCore.Mvc;
using MultiShop.Images.WebUı.Dal.Entities;
using MultiShop.Images.WebUı.Services;

namespace MultiShop.Images.WebUı.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICloudStorageService _cloudStorageService;

        public DefaultController(ICloudStorageService cloudStorageService)
        {
            _cloudStorageService = cloudStorageService;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ImageDrive ımageDrive)
        {
            
           if (ımageDrive.Photo != null)
           {
             ımageDrive.SavedFileName = GenerateFileNameToSave(ımageDrive.Photo.FileName);
             ımageDrive.SavedUrl = await _cloudStorageService.UploadFileAsync(ımageDrive.Photo, ımageDrive.SavedFileName);
           }
            return RedirectToAction("Index","Default");
        }

        private string? GenerateFileNameToSave(string incomingFileName)
        {
            var fileName = Path.GetFileNameWithoutExtension(incomingFileName);
            var extension = Path.GetExtension(incomingFileName);
            return $"{fileName}-{DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmss")}{extension}";
        }

    }
}
