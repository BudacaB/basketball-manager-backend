using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public interface ITeamService
    {
        Task<Team> GetTeam(string teamName);
        Task<List<Team>> GetAllTeams();
    }
}
