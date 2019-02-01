using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.Models
{
    public class Review
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int location_id { get; set; }
        public string rating { get; set; }
        public string comment { get; set; }
    }
}
