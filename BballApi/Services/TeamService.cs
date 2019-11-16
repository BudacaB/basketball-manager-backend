using BballApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public class TeamService : ITeamService
    {
        IMongoDatabase database;
        
        public TeamService()
        {
            var mongoClient = new MongoClient("mongodb://localhost:28017");
            database = mongoClient.GetDatabase("bball");
            
        }

        public async Task<Team> GetTeam(string teamName)
        {
            
            var filterByTeamName = Builders<BsonDocument>.Filter.Eq("name", teamName);
            var teamCollection = database.GetCollection<BsonDocument>("teams");
            var teamDoc = await teamCollection.Find(filterByTeamName).FirstOrDefaultAsync();
            var parsedToJsonString = teamDoc.ToJson();
            Team team = Newtonsoft.Json.JsonConvert.DeserializeObject<Team>(parsedToJsonString);

            return team;
        }


        //public List<Player> ListTeamPlayers()
        //{
        //    var teamList = new List<Player>();
        //    var playersCollection = database.GetCollection<BsonDocument>("players");

        //    var playerDocs = playersCollection.FindAsync(new BsonDocument()).Result.ToList();
        //    foreach (BsonDocument doc in playerDocs)
        //    {
        //        var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict };
        //        JObject playerAttributes = JObject.Parse(doc.ToJson(jsonWriterSettings));
        //        teamList.Add(new Player { FirstName = playerAttributes[1].ToString() });
        //    }

        //    return teamList;
        //}
    }
}