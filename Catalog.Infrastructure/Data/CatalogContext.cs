using Catalog.Core.Entities;
using Catalog.Infrastructure.Data.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext()
        {

        }

        public IMongoCollection<Product> Products { get; }
    }
}
