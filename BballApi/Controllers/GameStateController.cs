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
    public class GameStateController : ControllerBase
    {
        public IGameStateService _gameService;

        public GameStateController(IGameStateService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("/Games")]
        public async Task<ActionResult<List<GameViewModel>>> GetAllGames()
        {
            var result = await _gameService.GetAllGames();
            if (result.Count == 0) return NoContent();
            return Ok(result);

        }

        [Obsolete]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void PostGame(GameViewModel game)
        {
            _gameService.PostGame(game);
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
