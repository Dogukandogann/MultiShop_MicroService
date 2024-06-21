using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.UserIdentityServices;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserIdentityService _userIdentityService;

        public UserController(IUserIdentityService userIdentityService)
        {
            _userIdentityService = userIdentityService;
        }

        public async Task<IActionResult> UserList()
        {
            var userList = await _userIdentityService.GetAllUsersListAsync();
            return View(userList);
        }
    }
}
