
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pitch_A_Tent.DataAccess;
using Pitch_A_Tent.Models;
using Pitch_A_Tent.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly LocationStorage _storage;

        public LocationsController()
        {
            _storage = new LocationStorage();
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            return Ok(_storage.GetAllLocations());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleLocation(int id)
        {
            return Ok(_storage.GetSingleLocation(id));
        }

        [HttpPost]
        public IActionResult AddLocation(Locations location)
        {
            return Ok(_storage.AddLocation(location));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLocations(int id, Locations location)
        {
            return Ok(_storage.UpdateLocation(id, location));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            return Ok(_storage.DeleteLocation(id));
        }
    }
}