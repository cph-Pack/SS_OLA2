using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseManagerAPI
{
    public class ChemicalClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("Weight")]
        public int Weight { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("Location")]
        public WarehouseClass Location { get; set; }
    }
}
