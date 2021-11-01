using Catalog.Core.Entities;
using Catalog.WebAPI.Responses;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.WebAPI.Mapping
{
    public class Mapper : IMapper
    {
        public List<OrderResponse> MapOrderDtosToOrderResponses(IEnumerable<Order> orders)
        {
            return orders.Select(s => MapOrderDtoToOrderResponse(s)).ToList();
        }

        private OrderResponse MapOrderDtoToOrderResponse(Order order)
        {
            return new OrderResponse
            {
                OrderId = order.Id.ToString(),
                Delivered = order.Delivered,
                DeliveryDate = order.DeliveryDate
            };
        }
    }
}
