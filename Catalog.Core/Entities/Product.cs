using Catalog.Core.Attributes;
using Catalog.Core.Entities.Base;
using System;

namespace Catalog.Core.Entities
{
    [BsonCollection("product")]
    public record Product : Document
    {
        public string Name { get; init; }
        public string Category { get; init; }
        public string Description { get; set; }
        public decimal Price { get; init; }
        public DateTime ReleaseDate { get; init; }
    }
}
