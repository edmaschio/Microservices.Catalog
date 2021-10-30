using Catalog.Core.Attributes;
using Catalog.Core.Entities.Base;
using System;

namespace Catalog.Core.Entities
{
    [BsonCollection("customer")]
    public class Customer : Document
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
