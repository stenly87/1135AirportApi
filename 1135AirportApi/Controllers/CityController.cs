using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1135AirportApi.db;
using ModelsApi;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1135AirportApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly _1135_airportContext dbContext;

        public CityController(_1135_airportContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<CityController>
        [HttpGet]
        public IEnumerable<CityApi> Get()
        {
            var airports = dbContext.Airports.ToList();
            return dbContext.Cities.ToList().
                Select(s => { 
                    var result = (CityApi)s;
                    result.Airports = airports.Where(a => a.IdCity == s.Id).Select(a=> (AirportApi)a);
                    return result;
                });
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityApi>> Get(int id)
        {
            var city = await dbContext.Cities.FindAsync(id);
            if (city == null)
                return NotFound();
            var result = (CityApi)city;
            result.Airports = dbContext.Airports.Where(s => s.IdCity == id).Select(a => (AirportApi)a);
            return Ok();
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] CityApi value)
        {
            var newCity = (City)value;
            dbContext.Cities.Add(newCity);
            await dbContext.SaveChangesAsync();
            var ports = value.Airports.Select(s => (Airport)s);
            await dbContext.Airports.AddRangeAsync(ports);
            await dbContext.SaveChangesAsync();
            return Ok(newCity.Id);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CityApi value)
        {
            var oldCity = await dbContext.Cities.FindAsync(id);
            if (oldCity == null)
                return NotFound();
            oldCity.Airports = new HashSet<Airport>(value.Airports.Select(s =>
                    new Airport { Id = s.Id, Title = s.Title }));
            dbContext.Entry(oldCity).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldCity = await dbContext.Cities.FindAsync(id);
            if (oldCity == null)
                return NotFound();
            dbContext.Cities.Remove(oldCity);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
