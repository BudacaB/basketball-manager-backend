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

        [HttpGet("/Teams")]
        public async Task<ActionResult<List<Team>>> GetAllTeams()
        {
            var result = await _teamService.GetAllTeams();
            if (result.Count == 0) return NoContent();
            return Ok(result);
        }

        [HttpGet("/Team/{team}")]
        public async Task<ActionResult<Team>> GetTeam(string team)
        {
            var result = await _teamService.GetTeam(team);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [Obsolete]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [Obsolete]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [Obsolete]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
