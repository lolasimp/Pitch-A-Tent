using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pitch_A_Tent.DataAccess;
using Pitch_A_Tent.Models;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampTypeController : ControllerBase
    {
        public CampTypeStorage _storage;

        public CampTypeController()
        {
            _storage = new CampTypeStorage();
        }

        [HttpGet("/campsites")]
        public IActionResult GetAllCampTypes()
        {
            return Ok(_storage.GetAllCampsiteTypes());
        }

        [HttpGet("/campsites/{id}")]
        public IActionResult GetOneCampingType(int id)
        {
            return Ok(_storage.GetCampsiteTypeById(id));
        }

        [HttpPost]
        public IActionResult AddCampType(CampingType campsite)
        {
            return Ok(_storage.AddCampType(campsite));
        }



        //[HttpPut("{id}")]
        //public IActionResult UpdateCampingTypes([FromBody] string campsite, int id)
        //{
        //    return Ok(_storage.UpdateCampType(campsite, id));
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteCampingType(int id)
        //{
        //    return Ok(_storage.DeleteCampType(id));
        //}
    }

}