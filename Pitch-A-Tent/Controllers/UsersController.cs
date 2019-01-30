using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private string _connectionstring;

        public UsersController(IConfiguration configuration)
        {
            _connectionstring = configuration.GetSection("ConnectionString").Value;
        }


        [HttpGet("/login")]
        public IActionResult Login()
        {
            throw new NotImplementedException();
        }

        [HttpPost("/register")]
        public IActionResult Register()
        {
            throw new NotImplementedException();
        }
    }
}