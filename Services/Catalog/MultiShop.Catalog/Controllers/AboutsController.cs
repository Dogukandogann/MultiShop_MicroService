﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.AboutDtos;
using MultiShop.Catalog.Services.Aboutservice;

namespace MultiShop.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutsController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }
        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _AboutService.GetAllAboutAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutById(string id)
        {
            var values = await _AboutService.GetByIdAboutAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto AboutDto)
        {
            await _AboutService.CreateAboutAsync(AboutDto);
            return Ok("Hakkında Ekleme Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _AboutService.DeleteAboutAsync(id);
            return Ok("Hakkında Silme Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            await _AboutService.UpdateAboutAsync(updateAboutDto);
            return Ok("Hakkında Güncelleme Başarılı");
        }
    }
}
