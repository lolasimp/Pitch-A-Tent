using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Pitch_A_Tent.DataAccess;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ ApiController]
    public class UsersController : ControllerBase
    {

        public UsersStorage _storage;

        public UsersController()
        {
            _storage = new UsersStorage();
        }

        [HttpGet("")]
        public IActionResult GetAllUsers()
        {
            return Ok(_storage.GetAllUsers());
        }


        [HttpGet("/user/{id}")]
        public IActionResult GetSingleUser(int id)
        {
            return Ok(_storage.GetSingleUser(id));
        }


        //[HttpPost("/register")]
        //public IActionResult Register()
        //{
        //    throw new NotImplementedException();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteUser(int id)
        //{
        //    return Ok(_storage.DeleteSingleUser(id));
        //}
    }
}