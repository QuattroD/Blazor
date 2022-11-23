using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Blazor.Data
{
    public class AutorizationModel
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

    }
}
