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
        IMongoQueryable<TeamModel> teamsCollection;

        public TeamService()
        {
            teamsCollection = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<TeamModel>("teams")
                            .AsQueryable<TeamModel>();
        }

        public async Task<TeamModel> GetTeam(string teamName)
        {
            return await teamsCollection.FirstOrDefaultAsync(e => e.Name == teamName);
        }

        public async Task<List<TeamModel>> GetAllTeams()
        {
            return await teamsCollection.ToListAsync();
        }

    }
}