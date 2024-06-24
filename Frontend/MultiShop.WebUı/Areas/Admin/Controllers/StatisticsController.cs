using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUı.Services.CommentServices;
using MultiShop.WebUı.Services.StatisticsServices.CatalogStatisticsServices;
using MultiShop.WebUı.Services.StatisticsServices.DiscountStatisticsServices;
using MultiShop.WebUı.Services.StatisticsServices.MessageStatisticsServices;
using MultiShop.WebUı.Services.StatisticsServices.UserStatisticsServices;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticsController : Controller
    {
        private readonly ICatalogStatisticsService _catalogStatisticService;
        private readonly IUserStatisticsService _userStatisticService;
        private readonly ICommentService _commentService;
        private readonly IDiscountStatisticsService _discountStatisticService;
        private readonly IMessageStatisticsService _messageStatisticService;
        public StatisticsController(ICatalogStatisticsService catalogStatisticService, IUserStatisticsService userStatisticService, ICommentService commentService, IDiscountStatisticsService discountStatisticService, IMessageStatisticsService messageStatisticService)
        {
            _catalogStatisticService = catalogStatisticService;
            _userStatisticService = userStatisticService;
            _commentService = commentService;
            _discountStatisticService = discountStatisticService;
            _messageStatisticService = messageStatisticService;
        }

        public async Task<IActionResult> Index()
        {
            var getBrandCount = await _catalogStatisticService.GetBrandCount();
            var getProductCount = await _catalogStatisticService.GetProductCount();
            var getCategoryCount = await _catalogStatisticService.GetCategoryCount();
            var getMaxPriceProductName = await _catalogStatisticService.GetMaxPriceProductName();
            var getMinPriceProductName = await _catalogStatisticService.GetMinPriceProductName();

            var getUserCount = await _userStatisticService.GetUsercount();

            var getTotalCommentCount = await _commentService.GetTotalCommentCount();
            var getActiveCommentCount = await _commentService.GetActiveCommentCount();
            var getPassiveCommentCount = await _commentService.GetPAssiveCommentCount();

            var getDiscountCouponCount = await _discountStatisticService.GetDiscountCouponCount();

            var getMessageTotalCount = await _messageStatisticService.GetTotalMessageCount();

            ViewBag.getBrandCount = getBrandCount;
            ViewBag.getProductCount = getProductCount;
            ViewBag.getCategoryCount = getCategoryCount;
            ViewBag.getMaxPriceProductName = getMaxPriceProductName;
            ViewBag.getMinPriceProductName = getMinPriceProductName;

            ViewBag.getUserCount = getUserCount;

            ViewBag.getTotalCommentCount = getTotalCommentCount;
            ViewBag.getActiveCommentCount = getActiveCommentCount;
            ViewBag.getPassiveCommentCount = getPassiveCommentCount;

            ViewBag.getDiscountCouponCount = getDiscountCouponCount;

            ViewBag.getMessageTotalCount = getMessageTotalCount;

            return View();
        }
    }
}
