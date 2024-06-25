using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using MultiShop.Message.Dtos;
using MultiShop.Message.Services;

namespace MultiShop.Message.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMessageController : ControllerBase
    {
        private readonly IUserMessageService _userMessageService;

        public UserMessageController(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMessages()
        {
            var values = await _userMessageService.GetAllMessageAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
        {
            await _userMessageService.CreateMessageAsync(createMessageDto);
            return Ok("Mesaj Başarı İle Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _userMessageService.DeleteMessageAsync(id);
            return Ok("Mesaj Başarı İle Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            await _userMessageService.UpdateMessageAsync(updateMessageDto);
            return Ok("Mesaj Başarı İle Güncellendi");
        }
        [HttpGet("GetMessageSendBox")]
        public async Task<IActionResult> GetMessageSendBox(string id)
        {
            var values = await _userMessageService.GetSendboxMessageAsync(id);
            return Ok(values);
        }
        [HttpGet("GetMessageInboxBox")]
        public async Task<IActionResult> GetMessageInboxBox(string id)
        {
            var values = await _userMessageService.GetInboxMessageAsync(id);
            return Ok(values);
        }
        [HttpGet("GetTotalMessageCount")]
        public async Task<IActionResult> GetTotalMessageCount()
        {
            var values = await _userMessageService.GetTotalMessageCount();
            return Ok(values);
        }
        [HttpGet("GetTotalMessageCountByReceiverId")]
        public async Task<IActionResult> GetTotalMessageCountByReceiverId(string id)
        {
            var values = await _userMessageService.GetTotalMessageCountByReceiverId(id);
            return Ok(values);
        }

    }
}
