namespace MultiShop.WebUı.Services.StatisticsServices.MessageStatisticsServices
{
    public class MessageStatisticsService :IMessageStatisticsService
    {
        private readonly HttpClient _httpClient;
        public MessageStatisticsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> GetTotalMessageCount()
        {
            var responseMessage = await _httpClient.GetAsync("UserMessage/GetTotalMessageCount");
            var values = await responseMessage.Content.ReadFromJsonAsync<int>();
            return values;
        }
    }
}
