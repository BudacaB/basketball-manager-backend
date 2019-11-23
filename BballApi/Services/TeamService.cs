﻿using BballApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace BballApi.Services
{
    public class TeamService : ITeamService
    {
        IMongoQueryable<Team> teamsTable;

        public TeamService()
        {
            teamsTable = new MongoClient("mongodb://localhost:28017")
                            .GetDatabase("bball")
                            .GetCollection<Team>("teams")
                            .AsQueryable<Team>();
        }

        public async Task<Team> GetTeam(string teamName)
        {
            return await teamsTable.FirstOrDefaultAsync(e => e.Name == teamName);
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return await teamsTable.ToListAsync();
        }

    }
}