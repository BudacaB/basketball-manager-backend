using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Models
{
    [BsonIgnoreExtraElements]
    public class GameDataModel
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime Creation { get; set; }
    }
}
