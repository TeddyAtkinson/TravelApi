using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private readonly TravelApiContext _db;

        public DestinationsController(TravelApiContext db)
        {
            _db = db;
        }

        // GET: api/Destinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> GetDestinations(string Name, int TemperatureC, int Price)
        {
            IQueryable<Destination> query = _db.Destinations.AsQueryable();

            // 5001/api/destinations?name=Italy
            if(Name != null)
            {
                query = query.Where(destination => destination.Name == Name);
            }
            if(TemperatureC > -25)
            {
                query = query.Where(destination => destination.TemperatureC == TemperatureC);
            }
            if(Price >= 0)
            {
                query = query.Where(destination => destination.Price == Price);
            }
            return await query.ToListAsync();
        }

        // GET: api/Destinations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
            var destination = await _db.Destinations.FindAsync(id);

            if (destination == null)
            {
                return NotFound();
            }

            return destination;
        }

        // PUT: api/Destinations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestination(int id, Destination destination)
        {
            if (id != destination.DestinationId)
            {
                return BadRequest();
            }

            _db.Entry(destination).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Destinations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destination>> PostDestination(Destination destination)
        {
            _db.Destinations.Add(destination);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetDestination", new { id = destination.DestinationId }, destination);
        }

        // DELETE: api/Destinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestination(int id)
        {
            var destination = await _db.Destinations.FindAsync(id);
            if (destination == null)
            {
                return NotFound();
            }

            _db.Destinations.Remove(destination);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinationExists(int id)
        {
            return _db.Destinations.Any(e => e.DestinationId == id);
        }
    }
}
