using Catalog.Core.Attributes;
using System;

namespace Catalog.Core.Entities
{
    [BsonCollectionAttribute("customer")]
    public class Customer : Document
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
