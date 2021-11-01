using Catalog.WebAPI.Responses;
using MediatR;
using System.Collections.Generic;

namespace Catalog.WebAPI.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderResponse>>
    {
    }
}
