using Catalog.Core.Entities;
using Catalog.Core.Repositories.Interfaces;
using Catalog.WebAPI.Mapping;
using Catalog.WebAPI.Queries;
using Catalog.WebAPI.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.WebAPI.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderResponse>>
    {
        private readonly IMongoRepository<Order> _ordersRepository;
        private readonly IMapper _mapper;

        public GetAllOrdersHandler(IMongoRepository<Order> ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _ordersRepository.GetAllAsync();
            return _mapper.MapOrderDtosToOrderResponses(orders);
        }
    }
}
