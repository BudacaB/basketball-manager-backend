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
            gamesWriteCollection.InsertOne(GameMapper.MapToDataGame(game));
        }

        public async Task<List<GameViewModel>> GetAllGames()
        {
            List<GameDataModel> dataGames =  await gamesReadCollection.ToListAsync();
            List<GameViewModel> viewGames = new List<GameViewModel>();
            foreach (GameDataModel game in dataGames)
            {
                viewGames.Add(GameMapper.MapToViewGame(game));
            }
            return viewGames;
        }
    }
}
