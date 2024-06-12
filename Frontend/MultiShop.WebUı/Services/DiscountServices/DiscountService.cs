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
            var responseMessage = await _httpClient.GetAsync($"discount/GetCodeDetailByCode/{code}");
            var values = await responseMessage.Content.ReadFromJsonAsync<GetDiscountCodeDetail>();
            return values;
        }
    }
}
