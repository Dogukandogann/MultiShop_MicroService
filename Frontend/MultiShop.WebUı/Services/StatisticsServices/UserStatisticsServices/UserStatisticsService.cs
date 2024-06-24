using Newtonsoft.Json;

namespace MultiShop.WebUı.Services.StatisticsServices.UserStatisticsServices
{
    public class UserStatisticsService :IUserStatisticsService
    {
        private readonly HttpClient _httpClient;
        public UserStatisticsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> GetUsercount()
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:5001/Api/Statistics");
            var values = await responseMessage.Content.ReadFromJsonAsync<int>();
            return values;
        }
    }
}
