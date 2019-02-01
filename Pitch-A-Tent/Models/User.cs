using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.Models
{
    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public bool experienced_camper {get;set;}
        public int whishList_id { get; set; }
    }
}
