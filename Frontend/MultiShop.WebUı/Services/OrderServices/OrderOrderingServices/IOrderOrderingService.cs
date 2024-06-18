using MultiShop.DtoLayer.OrderDtos.OrderOrderingDtos;

namespace MultiShop.WebUı.Services.OrderServices.OrderOrderingServices
{
    public interface IOrderOrderingService
    {
        Task<List<ResultOrderingByUserIdDto>> GetOrderingByUserId(string id);
    }
}
