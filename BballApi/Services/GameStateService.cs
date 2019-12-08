using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class GameStateService : IGameStateService
    {
        IMongoCollection<GameDataModel> gamesWriteCollection;
        IMongoQueryable<GameDataModel> gamesReadCollection;
        public GameStateService()
        {
            gamesWriteCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<GameDataModel>("gameState");

            gamesReadCollection = gamesWriteCollection.AsQueryable<GameDataModel>();
        }

        public void PostGame(GameViewModel game)
        {
            var gameToInsert = new GameDataModel { Name = game.Name, Team = game.Team, Creation = DateTime.Now };
            gamesWriteCollection.InsertOne(gameToInsert);
        }

        public async Task<List<GameViewModel>> GetAllGames()
        {
            var dataGames =  await gamesReadCollection.ToListAsync();
            List<GameViewModel> viewGames = new List<GameViewModel>();
            foreach (GameDataModel game in dataGames)
            {
                viewGames.Add(new GameViewModel { Name = game.Name, Team = game.Team });
            }
            return viewGames;

        }
    }
}
