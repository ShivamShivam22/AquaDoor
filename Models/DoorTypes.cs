using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaDoor.Models
{
    public class DoorTypes
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Meterial { get; set; }
        public string DoorType { get; set; }

        public string LockType { get; set; }
        public Decimal Size { get; set; }
        public decimal Price { get; set; }

    }
}
