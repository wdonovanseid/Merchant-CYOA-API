using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using CYOA_Merchant_API.Models;

namespace CYOA_Merchant_API.Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {

        private CYOA_Merchant_APIContext _db;

        public LocationsController(CYOA_Merchant_APIContext db)
        {
            _db = db;
        }

        // GET api/locations
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get()
        {
            IEnumerable<Location> query = _db.Locations.AsQueryable();

            return query.OrderByDescending(x => x.LocationId).ToList();
        }

        // GET api/locations/5
        [HttpGet("{id}")]
        public ActionResult<Location> Get(Dictionary<string, int> Coordinates)
        {
            return _db.Locations.FirstOrDefault(entry => entry.LocationCoordinates == Coordinates);
        }

        // POST api/locations
        [HttpPost]
        public void Post([FromBody] Location location)
        {
            _db.Locations.Add(location);
            _db.SaveChanges();
        }

        // // PUT api/locations/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE api/locations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Location locationToDelete = _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
            _db.Locations.Remove(locationToDelete);
            _db.SaveChanges();
        }
    }
}
