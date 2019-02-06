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
    public class WishListsController : ControllerBase
    {
        public WishListStorage _storage;

        public WishListsController()
        {
            _storage = new WishListStorage();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_storage.GetAllWishLists());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_storage.GetWishListByUserId(id));
        }

        [HttpPost]
        public IActionResult AddNewWishList(WishLists wish)
        {
            return Ok(_storage.AddNewWishList(wish));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateWish(WishLists wish, int id)
        {
            return Ok(_storage.UpdateWish(wish, id));
        }
    }
}