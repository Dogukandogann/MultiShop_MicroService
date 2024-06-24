namespace MultiShop.WebUı.Services.StatisticsServices.DiscountStatisticsServices
{
    public class DiscountStatisticsService :IDiscountStatisticsService
    {
        private readonly HttpClient _httpClient;
        public DiscountStatisticsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> GetDiscountCouponCount()
        {
            var responseMessage = await _httpClient.GetAsync("Discount/GetDiscountCouponCountAsync");
            var values = await responseMessage.Content.ReadFromJsonAsync<int>();
            return values;
        }
    }
}
