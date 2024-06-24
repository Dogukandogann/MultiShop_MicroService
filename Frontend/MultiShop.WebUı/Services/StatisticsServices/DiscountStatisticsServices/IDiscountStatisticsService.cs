namespace MultiShop.WebUı.Services.StatisticsServices.DiscountStatisticsServices
{
    public interface IDiscountStatisticsService
    {
        Task<int> GetDiscountCouponCount();
    }
}
