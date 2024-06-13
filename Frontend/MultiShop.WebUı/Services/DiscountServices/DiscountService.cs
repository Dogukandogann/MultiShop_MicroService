using MultiShop.DtoLayer.DiscountDtos;

namespace MultiShop.WebUı.Services.DiscountServices
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _httpClient;

        public DiscountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetDiscountCodeDetail> GetDiscountCode(string code)
        {
            var responseMessage = await _httpClient.GetAsync($"http://localhost:7071/api/discount/GetCodeDetailByCodeAsync?code={code}");
            var values = await responseMessage.Content.ReadFromJsonAsync<GetDiscountCodeDetail>();
            return values;
        }
    }
}
