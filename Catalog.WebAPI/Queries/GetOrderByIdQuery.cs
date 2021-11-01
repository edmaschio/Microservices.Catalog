using Catalog.WebAPI.Responses;
using MediatR;

namespace Catalog.WebAPI.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public string OrderId { get; }
        public GetOrderByIdQuery(string id)
        {
            OrderId = id;
        }
    }
}
