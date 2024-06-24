namespace MultiShop.WebUı.Services.StatisticsServices.MessageStatisticsServices
{
    public interface IMessageStatisticsService
    {
        Task<int> GetTotalMessageCount();
    }
}
