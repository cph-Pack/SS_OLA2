using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WarehouseManagerAPI
{
    public class JobClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("Amount")]
        public int Amount { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("Desctription")]
        public string Description { get; set; }

        [BsonElement("Warehouse")]
        public WarehouseClass Warehouse { get; set; }

        [BsonElement("Chemical")]
        public ChemicalClass Chemical { get; set; }
    }
}
