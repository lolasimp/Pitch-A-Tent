using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.Models
{
    public class WishLists
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
