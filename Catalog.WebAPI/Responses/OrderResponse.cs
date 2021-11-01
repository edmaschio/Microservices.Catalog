using System;

namespace Catalog.WebAPI.Responses
{
    public class OrderResponse
    {
        public string OrderId { get; set; }
        public bool Delivered { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
