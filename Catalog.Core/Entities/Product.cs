using Catalog.Core.Attributes;
using Catalog.Core.Entities.Base;

namespace Catalog.Core.Entities
{
    [BsonCollection("product")]
    public class Product : Document
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
