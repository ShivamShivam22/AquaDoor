using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AquaDoor.Models
{
    public class DoorMeterialViewModel
    {
        public List<DoorTypes> DoorTypes { get; set; }
        public SelectList Meterial { get; set; }
        public string Door { get; set; }
        public string SearchString { get; set; }
    }
}
