using MultiShop.DtoLayer.BasketDtos;
using System.Runtime.InteropServices;

namespace MultiShop.WebUı.Services.BasketServices
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddBasketItem(BasketItemDto basketItem)
        {
            var values = await GetBasket() ?? new BasketTotalDto();
            if (!values.BasketItems.Any(x => x.ProductId.Equals(basketItem.ProductId)))
            {
                values.BasketItems.Add(basketItem);
            }
            await SaveBasket(values);
        }

        public Task DeleteBasket(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<BasketTotalDto> GetBasket()
        {
            var responseMessage = await _httpClient.GetAsync("basket");
            var values = await responseMessage.Content.ReadFromJsonAsync<BasketTotalDto>();
            return values;
        }

        public async Task<bool> RemoveBasketItem(string productId)
        {
            var values = await GetBasket();
            var deletedItem = values?.BasketItems.FirstOrDefault(x => x.ProductId.Equals(productId));

            if (deletedItem == null || !values.BasketItems.Remove(deletedItem))
            {
                return false;
            }

            await SaveBasket(values);
            return true;
        }

        public async Task SaveBasket(BasketTotalDto basket)
        {
            await _httpClient.PostAsJsonAsync<BasketTotalDto>("basket", basket);
        }
    }
}
