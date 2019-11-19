using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public int Weight { get; set; }
        public string College { get; set; }
        public int Salary { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public bool Injured { get; set; }
        public string Team { get; set; }
        public bool Playing { get; set; }
        public string Pic { get; set; }
    }
}