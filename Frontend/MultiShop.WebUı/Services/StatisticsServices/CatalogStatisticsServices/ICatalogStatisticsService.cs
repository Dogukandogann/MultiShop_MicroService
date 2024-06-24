namespace MultiShop.WebUı.Services.StatisticsServices.CatalogStatisticsServices
{
    public interface ICatalogStatisticsService
    {
        Task<long> GetCategoryCount();
        Task<long> GetProductCount();
        Task<long> GetBrandCount();
        Task<decimal> GetProductAvgPrice();
        Task<string> GetMaxPriceProductName();
        Task<string> GetMinPriceProductName();
    }
}
