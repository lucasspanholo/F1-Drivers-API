using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;


namespace Coding_Assessment.Models;

public class Driver : BaseModel
{
    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("surname")]
    public string Surname { get; set; }
    [BsonElement("nationality")]
    public string Nationality { get; set; }
    [BsonElement("number")]
    public int Number { get; set; }
    [BsonElement("points")]
    public int Points { get; set; }
}