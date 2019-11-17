using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using BballApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BballApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{player}")]
        public async Task<ActionResult<Player>> GetPlayer(string player)
        {
            return await _playerService.GetPlayer(player);
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
