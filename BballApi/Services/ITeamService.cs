using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public interface ITeamService
    {
        Task<TeamModel> GetTeam(string teamName);
        Task<List<TeamModel>> GetAllTeams();
    }
}
