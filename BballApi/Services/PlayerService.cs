using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class PlayerService : IPlayerService
    {
        IMongoQueryable<Player> playersCollection;

        public PlayerService()
        {
            playersCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Player>("players")
                            .AsQueryable<Player>();
        }
        public async Task<Player> GetPlayer(string playerName)
        {
            return await playersCollection.FirstOrDefaultAsync(e => e.LastName == playerName);
        }
    }
}
