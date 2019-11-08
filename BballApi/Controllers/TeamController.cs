using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BballApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BballApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        // GET: api/Team
        [HttpGet]
        public Player Get()
        {
            return new Player { Id = Guid.NewGuid(), FirstName = "Latrell", LastName = "Sprewell", Position = "Small Forward", Age = 27, Weight = 210, College = "UCLA", Salary = 4767000, Stamina = 87, Speed = 93, Strength = 91, Injured = false  };
            
            // string.Format("{0:0,0}", value) add commas for thousands to int
        }

        // GET: api/Team/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Team
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Team/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
