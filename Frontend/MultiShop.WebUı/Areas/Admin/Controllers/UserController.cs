using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.CargoServices.CargoCustomerServices;
using MultiShop.WebUı.Services.UserIdentityServices;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserIdentityService _userIdentityService;
        private readonly ICargoCustomerService _cargoCustomerService;

        public UserController(IUserIdentityService userIdentityService, ICargoCustomerService cargoCustomerService)
        {
            _userIdentityService = userIdentityService;
            _cargoCustomerService = cargoCustomerService;
        }

        public async Task<IActionResult> UserList()
        {
            var userList = await _userIdentityService.GetAllUsersListAsync();
            return View(userList);
        }
        public async Task<IActionResult> UserAddressInfo(string id)
        {
            var values = await _cargoCustomerService.GetByIdCargoCustomerInfoAsync(id);
            return View(values);
        }
    }
}
