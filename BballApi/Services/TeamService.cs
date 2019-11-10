using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public class TeamActions
    {
        public static List<Player> team = new List<Player>();
        public static List<Player> ListTeamPlayers()
        {
            team.Add(new Player { Id = Guid.NewGuid(), FirstName = "Latrell", LastName = "Sprewell", Position = "Small Forward", Age = 27, Height = 6.5m, Weight = 210, College = "UCLA", Salary = 4767000, Stamina = 87, Speed = 93, Strength = 91, Injured = false });
            team.Add(new Player { Id = Guid.NewGuid(), FirstName = "Shaq", LastName = "O'Neil", Position = "Center", Age = 32, Height = 7.1m, Weight = 300, College = "Arizona", Salary = 5345000, Stamina = 70, Speed = 75, Strength = 99, Injured = false });
            team.Add(new Player { Id = Guid.NewGuid(), FirstName = "Gary", LastName = "Payton", Position = "Point Guard", Age = 34, Height = 6.0m, Weight = 180, College = "Gonzaga", Salary = 3560000, Stamina = 93, Speed = 95, Strength = 75, Injured = false });
            team.Add(new Player { Id = Guid.NewGuid(), FirstName = "Michael", LastName = "Jordan", Position = "Shooting Guard", Age = 34, Height = 6.6m, Weight = 220, College = "NY", Salary = 6367000, Stamina = 97, Speed = 97, Strength = 88, Injured = false });
            team.Add(new Player { Id = Guid.NewGuid(), FirstName = "Tim", LastName = "Duncan", Position = "Power Forward", Age = 33, Height = 7.0m, Weight = 280, College = "Texas", Salary = 3836000, Stamina = 80, Speed = 80, Strength = 97, Injured = false });

            return team;
        }
    }
}