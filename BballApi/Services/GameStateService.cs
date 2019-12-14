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

        public static GameViewModel MapToViewGame(GameDataModel dataGame)
        {
            if (dataGame == null)
            {
                throw new ArgumentNullException(nameof(dataGame));
            }
            return new GameViewModel { Name = dataGame.Name, Team = dataGame.Team };
        }

        public static GameDataModel MapToDataGame(GameViewModel viewGame)
        {
            if (viewGame == null)
            {
                throw new ArgumentNullException(nameof(viewGame));
            }
            return new GameDataModel { Name = viewGame.Name, Team = viewGame.Team, Creation = DateTime.Now };
        }

        public GameStateService()
        {
            gamesWriteCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<GameDataModel>("gameState");

            gamesReadCollection = gamesWriteCollection.AsQueryable<GameDataModel>();
        }

        public void PostGame(GameViewModel game)
        {
            gamesWriteCollection.InsertOne(MapToDataGame(game));
        }

        public async Task<List<GameViewModel>> GetAllGames()
        {
            List<GameDataModel> dataGames =  await gamesReadCollection.ToListAsync();
            List<GameViewModel> viewGames = dataGames.Select(game => MapToViewGame(game)).ToList();
            
            return viewGames;
        }
    }
}
