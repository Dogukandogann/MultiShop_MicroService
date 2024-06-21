using MultiShop.DtoLayer.MessageDtos;

namespace MultiShop.WebUı.Services.MessageServices
{
    public interface IMessageService
    { 

        Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id);
        Task<List<ResultSendBoxMessageDto>> GetSendboxMessageAsync(string id);

    }
}
