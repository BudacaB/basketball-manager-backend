using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Models
{
    public class Team
    {
        public Team()
        {
            this.Roster = new List<string>();
            //null reference exception is avoided because we always initialize this in ctor
        }

        public string Name { get; set; }
        public List<string> Roster { get; set; }
        public string Pic { get; set; }
    }
}
