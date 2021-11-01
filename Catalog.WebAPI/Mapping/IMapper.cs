using Catalog.Core.Entities;
using Catalog.WebAPI.Responses;
using System.Collections.Generic;

namespace Catalog.WebAPI.Mapping
{
    public interface IMapper
    {
        List<OrderResponse> MapOrderDtosToOrderResponses(IEnumerable<Order> orders);
        OrderResponse MapOrderDtoToOrderResponse(Order order);
    }
}
