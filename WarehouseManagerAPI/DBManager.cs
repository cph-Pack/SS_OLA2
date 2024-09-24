using MongoDB.Driver;

namespace WarehouseManagerAPI
{
    public class DBManager
    {
        private const string connectionUri = "mogodb://localhost:27017";
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection
    }
}
