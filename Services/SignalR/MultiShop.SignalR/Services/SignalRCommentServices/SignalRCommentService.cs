
namespace MultiShop.SignalR.Services.SignalRCommentServices
{
    public class SignalRCommentService : ISignalRCommentService
    {
        private readonly HttpClient _httpClient;

        public SignalRCommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> GetTotalCommentCount()
        {
            var responseMessage = await _httpClient.GetAsync("UserMessage/GetTotalMessageCount");
            var values = await responseMessage.Content.ReadFromJsonAsync<int>();
            return values;
        }
    }
}
