using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUı.Models;
using MultiShop.WebUı.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUı.Controllers
{
    public class LoginController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IIdentityService _identityService;
        public LoginController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;
            _identityService = identityService;
        }
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
		{
			return View();
		}

		//[HttpPost]
		public async Task<IActionResult> SignIn(SignInDto signInDto)
		{
            
			signInDto.UserName = "ali01";
            signInDto.Password = "123456aA*";
			await _identityService.SignIn(signInDto);
			return RedirectToAction("Index","User");
        }
	}
}
