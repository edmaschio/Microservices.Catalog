using Catalog.Core.Attributes;
using Catalog.Core.Entities.Base;
using System;

namespace Catalog.Core.Entities
{
    [BsonCollection("order")]
    public record Order : Document
    {
        //public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        //public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public bool Delivered { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
