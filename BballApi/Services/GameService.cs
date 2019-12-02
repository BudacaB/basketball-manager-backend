using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class GameService : IGameService
    {
        IMongoCollection<Game> gamesWriteCollection;
        IMongoQueryable<Game> gamesReadCollection;
        public GameService()
        {
            gamesWriteCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Game>("gameState");

            gamesReadCollection = gamesWriteCollection.AsQueryable<Game>();
        }

        public void PostGame(ReceivedGame game)
        {
            var gameToInsert = new Game { Name = game.Name, Team = game.Team, Creation = DateTime.Now };
            gamesWriteCollection.InsertOne(gameToInsert);
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await gamesReadCollection.ToListAsync();
        }
    }
}
