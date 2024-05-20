using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUı.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUı.Controllers
{
	public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public LoginController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
		{
			var client = _httpClientFactory.CreateClient();
			var content = new StringContent(JsonSerializer.Serialize(createLoginDto), Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:5001/api/Logins", content);
			if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();
				var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
				{
					PropertyNamingPolicy = JsonNamingPolicy.CamelCase
				});
				if (tokenModel is not null)
				{
					JwtSecurityTokenHandler hander = new JwtSecurityTokenHandler();
					var token = hander.ReadJwtToken(tokenModel.Token);
					var claims = token.Claims.ToList();

                    if (tokenModel.Token is not null)
                    {
						claims.Add(new Claim("MultiShopToken",tokenModel.Token));
						var claimsIdentity = new ClaimsIdentity(claims,JwtBearerDefaults.AuthenticationScheme);
						var authProps = new AuthenticationProperties{ 
						ExpiresUtc= tokenModel.ExpireDate,
						IsPersistent = true
						};
						await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),authProps);
						return RedirectToAction("Index","Default");
                    }
                }
			}
			return View();

		}
	}
}
