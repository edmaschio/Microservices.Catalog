using Catalog.Core.Entities;
using Catalog.Core.Repositories.Interfaces;
using Catalog.WebAPI.Mapping;
using Catalog.WebAPI.Queries;
using Catalog.WebAPI.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.WebAPI.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderResponse>
    {
        private readonly IMongoRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderByIdHandler(IMongoRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.FindByIdAsync(request.OrderId);

            if (order == null)
            {
                return null;
            }

            return _mapper.MapOrderDtoToOrderResponse(order);
        }
    }
}
