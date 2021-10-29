namespace Catalog.Core.Settings
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; }
        string ConnectionString { get; }
    }
}
