using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pitch_A_Tent.DataAccess;
using Pitch_A_Tent.Models;

namespace Pitch_A_Tent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public ReviewStorage _storage;

        public ReviewController()
        {
            _storage = new ReviewStorage();
        }

        //wishItem
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_storage.GetAllReviews());
        }

        //wishItem/id
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_storage.GetReviewByLocationId(id));
        }

        //wishItem
        [HttpPost]
        public IActionResult AddNewReview([FromBody]Review review)
        {
            return Ok(_storage.AddReview(review));
        }

        //wishItem/id
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            return Ok(_storage.DeleteReview(id));
        }
    }

}