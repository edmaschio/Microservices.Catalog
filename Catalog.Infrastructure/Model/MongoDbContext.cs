using MongoDB.Driver;

namespace Catalog.Infrastructure.Model
{
    public class MongoDbContext
    {
        public readonly IMongoDatabase Database;

        public MongoDbContext(IMongoClient client, string dbName)
        {
            Database = client.GetDatabase(dbName);
        }
    }
}
