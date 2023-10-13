using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AquaDoor.Models;

namespace AquaDoor.Data
{
    public class AquaDoorContext : DbContext
    {
        public AquaDoorContext(DbContextOptions<AquaDoorContext> options)
            : base(options)
        {
        }

        public DbSet<DoorTypes> Doors { get; set; }
    }
}
