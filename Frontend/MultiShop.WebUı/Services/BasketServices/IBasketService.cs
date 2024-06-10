using MultiShop.DtoLayer.BasketDtos;

namespace MultiShop.WebUı.Services.BasketServices
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket();
        Task SaveBasket(BasketTotalDto basket);
        Task DeleteBasket(string userId);
        Task AddBasketItem(BasketItemDto basketItem);
        Task<bool> RemoveBasketItem(string productId);
    }
}
