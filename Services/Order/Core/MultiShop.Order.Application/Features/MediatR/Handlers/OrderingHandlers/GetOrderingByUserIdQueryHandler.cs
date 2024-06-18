﻿using MediatR;
using MultiShop.Order.Application.Features.MediatR.Queries.OrderingQueries;
using MultiShop.Order.Application.Features.MediatR.Results.OrderingResult;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.MediatR.Handlers.OrderingHandlers
{
    public class GetOrderingByUserIdQueryHandler : IRequestHandler<GetOrderingByUserIdQuery, List<GetOrderingByUserIdQueryResult>>
    {
        private readonly IOrderingRepository _orderingRepository;

        public GetOrderingByUserIdQueryHandler(IOrderingRepository orderingRepository)
        {
            _orderingRepository = orderingRepository;
        }

        public async Task<List<GetOrderingByUserIdQueryResult>> Handle(GetOrderingByUserIdQuery request, CancellationToken cancellationToken)
        {
            var values = _orderingRepository.GetOrderingsByUserId(request.UserId);
            return values.Select(x => new GetOrderingByUserIdQueryResult
            {
                OrderDate = x.OrderDate,
                OrderingId = x.OrderingId,
                UserId = x.UserId,
                TotalPrice = x.TotalPrice,
            }).ToList();

        }
    }
}
