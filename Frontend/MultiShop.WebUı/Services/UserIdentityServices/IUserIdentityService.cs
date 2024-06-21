using MultiShop.DtoLayer.IdentityDtos.UserDtos;

namespace MultiShop.WebUı.Services.UserIdentityServices
{
    public interface IUserIdentityService
    {
        Task<List<ResultUserDto>> GetAllUsersListAsync();
    }
}
