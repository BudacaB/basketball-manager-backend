using BballApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class TeamService : ITeamService
    {
        IMongoQueryable<Team> teamsCollection;

        public TeamService()
        {
            teamsCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Team>("teams")
                            .AsQueryable<Team>();
        }

        public async Task<Team> GetTeam(string teamName)
        {
            return await teamsCollection.FirstOrDefaultAsync(e => e.Name == teamName);
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return await teamsCollection.ToListAsync();
        }

    }
}