using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUı.Services.Interfaces;
using MultiShop.WebUı.Settings;
using System.Security.Claims;
using System.Security.Principal;

namespace MultiShop.WebUı.Services.Concrete
{
    public class IdentityService : IIdentityService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ClientSettings _clientSettings;
        private readonly ServiceApiSettings _serviceApiSettings;

        public IdentityService(HttpClient httpClient, IHttpContextAccessor contextAccessor, IOptions<ClientSettings> clientSettings, IOptions<ServiceApiSettings> serviceApiSettings)
        {
            _httpClient = httpClient;
            _contextAccessor = contextAccessor;
            _clientSettings = clientSettings.Value;
            _serviceApiSettings = serviceApiSettings.Value;
        }

        public async Task<bool> GetRefreshToken()
        {
            var discoveryEndPoint = await _httpClient.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest()
            {
                Address = _serviceApiSettings.IdentityUrl,
                Policy = new DiscoveryPolicy
                {
                    RequireHttps = false
                }
            });

            var refreshToken = await _contextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.RefreshToken);

            RefreshTokenRequest refreshTokenRequest = new()
            {
                ClientId = _clientSettings.MultiShopManagerClient.ClientId,
                ClientSecret = _clientSettings.MultiShopManagerClient.ClientSecret,
                RefreshToken = refreshToken,
                Address = discoveryEndPoint.TokenEndpoint
            };
            var token = await _httpClient.RequestRefreshTokenAsync(refreshTokenRequest);
            var authenticationToken = new List<AuthenticationToken>
            {
                new AuthenticationToken
                {
                    Name=OpenIdConnectParameterNames.AccessToken,
                    Value = token.AccessToken,
                },
                new AuthenticationToken
                {
                    Name=OpenIdConnectParameterNames.RefreshToken,
                    Value = token.RefreshToken,
                },
                new AuthenticationToken
                {
                    Name = OpenIdConnectParameterNames.ExpiresIn,
                    Value = DateTime.Now.AddSeconds(token.ExpiresIn).ToString(),
                }
            };

            var result = await _contextAccessor.HttpContext.AuthenticateAsync();
            var properties = result.Properties;
            properties.StoreTokens(authenticationToken);
            await _contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,result.Principal,properties);
            return true;
        }

        public async Task<bool> SignIn(SignInDto signInDto)
        {
            var discoveryEndPoint = await _httpClient.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest()
            {
                Address= _serviceApiSettings.IdentityUrl,
                Policy= new DiscoveryPolicy
                {
                    RequireHttps=false
                }
            });
            var passwordTokenRequest = new PasswordTokenRequest
            {
                ClientId = _clientSettings.MultiShopManagerClient.ClientId,
                ClientSecret = _clientSettings.MultiShopManagerClient.ClientSecret,
                UserName = signInDto.UserName,
                Password = signInDto.Password,
                Address = discoveryEndPoint.TokenEndpoint
            };
            var token = await _httpClient.RequestPasswordTokenAsync(passwordTokenRequest);

            var userInfo = new UserInfoRequest
            {
                Address = discoveryEndPoint.UserInfoEndpoint,
                Token = token.AccessToken,
            };
            var userValues = await _httpClient.GetUserInfoAsync(userInfo);

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(userValues.Claims,CookieAuthenticationDefaults.AuthenticationScheme,"name","role");
            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

            var authenticationProps = new AuthenticationProperties();
            authenticationProps.StoreTokens(new List<AuthenticationToken>()
            {
                new AuthenticationToken
                {
                    Name=OpenIdConnectParameterNames.AccessToken,
                    Value = token.AccessToken,
                },
                new AuthenticationToken
                {
                    Name=OpenIdConnectParameterNames.RefreshToken,
                    Value = token.RefreshToken,
                },
                new AuthenticationToken
                {
                    Name = OpenIdConnectParameterNames.ExpiresIn,
                    Value = DateTime.Now.AddSeconds(token.ExpiresIn).ToString(),
                }
            });
            authenticationProps.IsPersistent = false;
            await _contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProps);

            return true;

        }
       
    }
}
