using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BballApi.Services
{
    public class PlayerService : IPlayerService
    {
        IMongoDatabase database;

        public PlayerService()
        {
            var mongoClient = new MongoClient("mongodb://localhost:28017");
            database = mongoClient.GetDatabase("bball");

        }
        public async Task<Player> GetPlayer(string playerName)
        {
            var filterByPlayerLastName = Builders<BsonDocument>.Filter.Eq("lastname", playerName);
            var playerCollection = database.GetCollection<BsonDocument>("players");
            var playerDoc = await playerCollection.Find(filterByPlayerLastName).FirstOrDefaultAsync();
            var parseToJsonString = playerDoc.ToJson();
            Player player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(parseToJsonString);

            return player;
        }
    }
}
