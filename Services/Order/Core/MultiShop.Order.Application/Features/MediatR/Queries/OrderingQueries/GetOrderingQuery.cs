using MediatR;
using MultiShop.Order.Application.Features.MediatR.Results.OrderingResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.MediatR.Queries.OrderingQueries
{
    public class GetOrderingQuery :IRequest<List<GetOrderingQueryResult>>
    {

    }
}
