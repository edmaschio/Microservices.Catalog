using Catalog.Core.Attributes;
using Catalog.Core.Entities.Base;
using System;

namespace Catalog.Core.Entities
{
    [BsonCollection("customer")]
    public record Customer : Document
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
    }
}
