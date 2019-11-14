using BballApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public  class TeamService
    {
        IMongoDatabase database;
        
        TeamService()
        {
            var mongoClient = new MongoClient("mongodb://localhost:28017");
            database = mongoClient.GetDatabase("bball");
        }
        public List<Player> ListTeamPlayers()
        {
            var teamList = new List<Player>();

            // 1. Research mongo .net driver docs - how to read a collection
            // 2. Singleton (1 instance of service for all) - https://www.youtube.com/watch?v=hUE_j6q0LTQ

            //database.ListCollections

            return teamList;
        }
    }
}