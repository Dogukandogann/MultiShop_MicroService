using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOrderDetailCommand updateOrderDetailCommand)
        {
            var value = await _repository.GetByIdAsync(updateOrderDetailCommand.OrderDetailId);
            value.OrderingId=updateOrderDetailCommand.OrderingId;
            value.ProductId=updateOrderDetailCommand.ProductId;
            value.ProductPrice=updateOrderDetailCommand.ProductPrice;
            value.ProductName=updateOrderDetailCommand.ProductName;
            value.ProductTotalPrice=updateOrderDetailCommand.ProductTotalPrice;
            value.ProductAmount=updateOrderDetailCommand.ProductAmount;
            await _repository.UpdateAsync(value);
        }
    }
}
