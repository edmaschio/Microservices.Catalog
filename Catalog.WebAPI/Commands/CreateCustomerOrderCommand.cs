using Catalog.WebAPI.Responses;
using MediatR;

namespace Catalog.WebAPI.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
    }
}
