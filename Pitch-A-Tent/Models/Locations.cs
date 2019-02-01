using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.Models
{
    public class Locations
    {
    public int id { get; set; }
    public int campingTypeId { get; set; }
    public int reveiewId { get; set; }
    public string name { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string description { get; set; }
    public string img { get; set; }
    public bool glamping { get; set; }
    public bool backcountry { get; set; }
    public bool modern_camping { get; set; }
    public string latLong { get; set; }
    public string parkCode { get; set; }
    public DateTime hourOfOperation { get; set; }
    }
}
