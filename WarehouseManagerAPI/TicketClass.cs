using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseManagerAPI
{
    public class TicketClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Chemicals")]
        public List<ChemicalClass> Chemicals { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

    }
}
