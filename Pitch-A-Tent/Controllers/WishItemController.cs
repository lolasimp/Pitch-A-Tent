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
    public class WishItemController : ControllerBase
    {
        public WishItemStorage _storage;

        public WishItemController()
        {
            _storage = new WishItemStorage();
        }

        //wishItem
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_storage.GetAllWishItems());
        }

        //wishItem/id
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_storage.GetWishItemByUserId(id));
        }

        //wishItem
        [HttpPost]
        public IActionResult AddNewWishItem(WishItem wishItem)
        {
            return Ok(_storage.AddNewWishItem(wishItem));
        }

        //wishItem/id
        [HttpDelete("{id}")]
        public IActionResult DeleteWishItem(int id)
        {
            return Ok(_storage.DeleteWishItem(id));
        }
    }
}