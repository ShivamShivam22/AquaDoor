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

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ProductName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Meterial { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string DoorType { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LockType { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public Decimal Size { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
