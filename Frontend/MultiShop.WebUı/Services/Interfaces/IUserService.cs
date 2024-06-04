using MultiShop.WebUı.Models;

namespace MultiShop.WebUı.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDetailViewModel> GetUserInfo();
    }
}
