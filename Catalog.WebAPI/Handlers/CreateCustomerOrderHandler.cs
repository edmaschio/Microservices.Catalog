using Catalog.Core.Entities;
using Catalog.Core.Repositories.Interfaces;
using Catalog.WebAPI.Commands;
using Catalog.WebAPI.Mapping;
using Catalog.WebAPI.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.WebAPI.Handlers
{
    public class CreateCustomerOrderHandler : IRequestHandler<CreateCustomerOrderCommand, OrderResponse>
    {
        private readonly IMongoRepository<Order> _orderRepository;
        private readonly ILogger<CreateCustomerOrderHandler> _logger;
        private readonly IMapper _mapper;

        public CreateCustomerOrderHandler(ILogger<CreateCustomerOrderHandler> logger, IMongoRepository<Order> orderRepository, IMapper mapper)
        {
            _logger = logger;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(CreateCustomerOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order { CustomerId = request.CustomerId, ProductId = request.ProductId, Delivered = false };
            await _orderRepository.InsertOneAsync(order);
            _logger.LogInformation($"Create order for customer: {order.CustomerId} for product: {order.ProductId}");

            return _mapper.MapOrderDtoToOrderResponse(order);
        }
    }
}
