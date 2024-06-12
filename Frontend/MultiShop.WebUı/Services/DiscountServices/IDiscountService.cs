using MultiShop.DtoLayer.DiscountDtos;

namespace MultiShop.WebUı.Services.DiscountServices
{
    public interface IDiscountService
    {
        Task<GetDiscountCodeDetail> GetDiscountCode(string code);
    }
}
