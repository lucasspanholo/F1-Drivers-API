using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coding_Assessment.Models;

public abstract class BaseModel
{
    [BsonId]
    // [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [BsonElement("updatedAt")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}