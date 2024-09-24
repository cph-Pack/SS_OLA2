using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseManagerAPI
{
    public class WarehouseClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Location")]
        public string Location { get; set; }

        [BsonElement("Chemicals")]
        public List<ChemicalClass> Chemicals { get; set; }
    }
}
