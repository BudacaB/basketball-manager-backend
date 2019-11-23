using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class PlayerService : IPlayerService
    {
        IMongoQueryable<Player> playerTable;

        public PlayerService()
        {
            playerTable = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Player>("players")
                            .AsQueryable<Player>();
        }
        public async Task<Player> GetPlayer(string playerName)
        {
            return await playerTable.FirstOrDefaultAsync(e => e.LastName == playerName);
        }
    }
}
