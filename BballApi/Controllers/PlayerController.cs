using System;
using System.Threading.Tasks;
using BballApi.Models;
using BballApi.Services;
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
        public async Task<ActionResult<PlayerModel>> GetPlayer(string player)
        {
            //var randomInterval = new Random();
            //await Task.Delay(TimeSpan.FromSeconds(randomInterval.Next(0, 4)));
            var result = await _playerService.GetPlayer(player);
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
