using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsitesController : ControllerBase
    {
        private string _connectionString;

        public CampsitesController(IConfiguration configuration)
        {
            _connectionString = configuration.GetSection("ConnectionString").Value;
        }

        //[HttpGet("/campsites")]
        //public IEnumerable<Campste>
    }

}