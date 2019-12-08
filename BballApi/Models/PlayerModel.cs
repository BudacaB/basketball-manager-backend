using MongoDB.Bson.Serialization.Attributes;

namespace BballApi.Models
{
    [BsonIgnoreExtraElements]
    public class PlayerModel
    {
        [BsonElement("firstname")]
        public string FirstName { get; set; }
        [BsonElement("lastname")]
        public string LastName { get; set; }
        [BsonElement("position")]
        public string Position { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("height")]
        public decimal Height { get; set; }
        [BsonElement("weight")]
        public int Weight { get; set; }
        [BsonElement("college")]
        public string College { get; set; }
        [BsonElement("salary")]
        public int Salary { get; set; }
        [BsonElement("stamina")]
        public int Stamina { get; set; }
        [BsonElement("speed")]
        public int Speed { get; set; }
        [BsonElement("strength")]
        public int Strength { get; set; }
        [BsonElement("injured")]
        public bool Injured { get; set; }
        [BsonElement("team")]
        public string Team { get; set; }
        [BsonElement("playing")]
        public bool Playing { get; set; }
        [BsonElement("pic")]
        public string PhotoURL { get; set; }
    }
}