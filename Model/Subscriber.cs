using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace csharp_mongodb.Model
{
    public class Subscriber
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string PhoneNo { get; set; }

        public string Country { get; set; }

        public string  Address { get; set; }
    }
}