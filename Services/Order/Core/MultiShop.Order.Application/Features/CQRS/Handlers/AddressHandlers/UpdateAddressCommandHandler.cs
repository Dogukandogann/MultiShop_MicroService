using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAddressCommand updateAddressCommand)
        {
            var value = await _repository.GetByIdAsync(updateAddressCommand.AddressId);
            value.Detail1 = updateAddressCommand.Detail;
            value.District = updateAddressCommand.District;
            value.City = updateAddressCommand.City;
            value.UserId = updateAddressCommand.UserId;
            await _repository.UpdateAsync(value);
        }
    }
}
