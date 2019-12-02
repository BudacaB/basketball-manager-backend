using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace BballApi.Services
{
    public class GameService : IGameService
    {
        IMongoCollection<Game> gamesCollection;
        public GameService()
        {
            gamesCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Game>("gameState");
        }

        public void PostGame(ReceivedGame game)
        {
            var gameToInsert = new Game { Name = game.Name, Team = game.Team, Creation = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") };
            gamesCollection.InsertOne(gameToInsert);
        }
    }
}
