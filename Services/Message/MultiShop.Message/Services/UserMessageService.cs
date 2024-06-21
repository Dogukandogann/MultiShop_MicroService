﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MultiShop.Message.Dal.Context;
using MultiShop.Message.Dal.Entities;
using MultiShop.Message.Dtos;

namespace MultiShop.Message.Services
{
    public class UserMessageService : IUserMessageService
    {
        private readonly MessageContext _messageContext;
        private readonly IMapper _mapper;

        public UserMessageService(MessageContext messageContext, IMapper mapper)
        {
            _messageContext = messageContext;
            _mapper = mapper;
        }

        public async Task CreateMessageAsync(CreateMessageDto createMessageDto)
        {
            var values = _mapper.Map<UserMessage>(createMessageDto);
            await _messageContext.UserMessages.AddAsync(values);
            await _messageContext.SaveChangesAsync();
        }

        public async Task DeleteMessageAsync(int id)
        {
            var values = await _messageContext.UserMessages.FindAsync(id);
            _messageContext.UserMessages.Remove(values);
            await _messageContext.SaveChangesAsync();

        }

        public async Task<List<ResultMessageDto>> GetAllMessageAsync()
        {
            var values = await _messageContext.UserMessages.ToListAsync();
            return _mapper.Map<List<ResultMessageDto>>(values);
        }

        public async Task<GetByIdMessageDto> GetByIdMessageAsync(int id)
        {
            var values = await _messageContext.UserMessages.FindAsync(id);
            return _mapper.Map<GetByIdMessageDto>(values);
        }

        public async Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id)
        {
            var values = await _messageContext.UserMessages.Where(x => x.ReceiverId.Equals(id)).ToListAsync();
            return _mapper.Map<List<ResultInboxMessageDto>>(values);
        }

        public async Task<List<ResultSendBoxMessageDto>> GetSendboxMessageAsync(string id)
        {
            var values = await _messageContext.UserMessages.Where(x => x.SenderId.Equals(id)).ToListAsync();
            return _mapper.Map<List<ResultSendBoxMessageDto>>(values);
        }

        public async Task UpdateMessageAsync(UpdateMessageDto updateMessageDto)
        {
            var values = _mapper.Map<UserMessage>(updateMessageDto);
            _messageContext.UserMessages.Update(values);
            await _messageContext.SaveChangesAsync();
        }
    }
}
