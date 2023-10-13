using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AquaDoor.Data;
using System;
using System.Linq;

namespace AquaDoor.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AquaDoorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AquaDoorContext>>()))
            {
                // Look for any Doors.
                if (context.Doors.Any())
                {
                    return;   // DB has been seeded
                }

                context.Doors.AddRange(
                    new DoorTypes
                    {
                        ProductName = "AquaDoor Mega",
                        Meterial = "Wooden",
                        DoorType = "Double",
                        LockType = "Key",
                        Size = 15,
                        Price = 12000

                    },

                    new DoorTypes
                    {

                        ProductName = "AquaDoor Plus",
                        Meterial = "Steel",
                        DoorType = "Single",
                        LockType = "Digital",
                        Size = 7,
                        Price = 8000

                    },

                    new DoorTypes
                    {
                        ProductName = "Door M732",
                        Meterial = "Steel",
                        DoorType = "Single",
                        LockType = "Digital",
                        Size = 10,
                        Price = 5000

                    },

                    new DoorTypes
                    {
                        ProductName = "Door S0001",
                        Meterial = "aluminum",
                        DoorType = "Single",
                        LockType = "Key",
                        Size = 6,
                        Price = 2000

                    },

                    new DoorTypes
                    {

                        ProductName = "Secutity ++",
                        Meterial = "Metal",
                        DoorType = "Single",
                        LockType = "Dial",
                        Size = 14,
                        Price = 34000


                    },

                    new DoorTypes
                    {
                        ProductName = "AquaDoor Premium",
                        Meterial = "Wooden",
                        DoorType = "Double",
                        LockType = "Key/Digital",
                        Size = 10,
                        Price = 14000


                    }
                );
                context.SaveChanges();
            }
        }
    }
}