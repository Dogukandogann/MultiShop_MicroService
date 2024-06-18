using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.Interfaces;
using MultiShop.WebUı.Services.OrderServices.OrderOrderingServices;

namespace MultiShop.WebUı.Areas.User.Controllers
{
    [Area("User")]
    public class MyOrderController : Controller
    {
        private readonly IOrderOrderingService _orderOrderingService;
        private readonly IUserService _userService;

        public MyOrderController(IOrderOrderingService orderOrderingService, IUserService userService)
        {
            _orderOrderingService = orderOrderingService;
            _userService = userService;
        }

        public async Task<IActionResult> MyOrderList()
        {
            var userId = await _userService.GetUserInfo();
            var values = await _orderOrderingService.GetOrderingByUserId(userId.Id);
            return View(values);
        }
    }
}
