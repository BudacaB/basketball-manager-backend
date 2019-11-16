using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using BballApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BballApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        public ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("{team}")]
        public async Task<ActionResult<Team>> Get(string team)
        {
            return await _teamService.GetTeam(team);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
