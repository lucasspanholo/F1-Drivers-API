using MongoDB.Bson.Serialization.Attributes;

namespace Coding_Assessment.Models;

public class Championship : BaseModel
{
    [BsonElement("year")]
    [BsonRequired]
    public int Ano { get; set; }
    
    [BsonElement("totalRaces")]
    public int TotalRaces { get; set; } = 0;
    
    [BsonElement("completedRaces")]
    public int CompletedRaces { get; set; } = 0;
    
    [BsonElement("remainingRaces")]
    public int RemainingRaces => TotalRaces - CompletedRaces;
}