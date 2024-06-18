using MediatR;
using MultiShop.Order.Application.Features.MediatR.Results.OrderingResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.MediatR.Queries.OrderingQueries
{
    public class GetOrderingByUserIdQuery :IRequest<List<GetOrderingByUserIdQueryResult>>
    {
        public string UserId { get; set; }

        public GetOrderingByUserIdQuery(string userId)
        {
            UserId = userId;
        }
    }
}
