using MultiShop.DtoLayer.IdentityDtos.LoginDtos;

namespace MultiShop.WebUı.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInDto signInDto);
        Task<bool> GetRefreshToken();
    }
}
