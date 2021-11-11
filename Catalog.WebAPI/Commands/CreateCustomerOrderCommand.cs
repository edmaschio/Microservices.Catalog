using Catalog.WebAPI.Responses;
using MediatR;
using System;

namespace Catalog.WebAPI.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
    }
}
