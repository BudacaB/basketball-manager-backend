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
    public class GameController : ControllerBase
    {
        public IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [Obsolete]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Obsolete]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void PostGame(ReceivedGame game)
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
