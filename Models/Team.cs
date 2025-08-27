using MongoDB.Bson.Serialization.Attributes;

namespace Coding_Assessment.Models;

public class Team : BaseModel
{
    [BsonElement("team")]
    public string TeamName { get; set; }
    [BsonElement("teamNationality")]
    public string TeamNationality { get; set; }
}