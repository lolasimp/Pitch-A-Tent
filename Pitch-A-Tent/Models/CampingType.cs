using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.Models
{
    public class CampingType
{
    public int id { get; set; }
    public int location_id { get; set; }
    public bool glamping { get; set; }
    public bool backcountry { get; set; }
    public bool modern_camping { get; set; }
    public bool tent_only { get; set; }
    public bool electricalHookUp{ get; set; }
    public bool rvOnly { get; set; }
    public bool state_national_park { get; set;}
    public bool internetConnectivity { get; set; }
    public bool campStore { get; set; }
    public bool showers { get; set; }
    public bool toilets { get; set; }
    public bool cell_phone_reception { get; set; }
    public bool laundry { get; set; }
    public bool dumpStation { get; set; }
    public bool staffOnSite { get; set; }
    public bool fireStovePolicy { get; set; }
    public bool wheelchairaccess { get; set; }
    public bool adainfo { get; set; }
    public bool accessRoad { get; set; }
    public bool potableWater { get; set; }
    public bool firewood_for_sale { get; set; }
    public bool food_storage_locker { get; set; }
    }
}
