using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseManagerAPI
{
    public class DepotClass
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Warehouses")]
        public List<WarehouseClass> WarehouseClasses { get; set; }
        [BsonElement("Capacity")]
        public int Capacity { get; set; }
    }
}
