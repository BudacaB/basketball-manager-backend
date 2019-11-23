using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace BballApi.Models
{
    [BsonIgnoreExtraElements]
    public class Team
    {
        public Team()
        {
            this.Roster = new List<string>();
            //null reference exception is avoided because we always initialize this in ctor
        }

        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("roster")]
        public List<string> Roster { get; set; }
        [BsonElement("pic")]
        public string PhotoURL { get; set; }
    }
}
