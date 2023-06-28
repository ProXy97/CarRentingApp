using CarRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Data.Configurations
{
    public class ExtraEntityConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            ICollection<Extra> extras = CreateExtras();
            builder.HasData(extras);
        }

        private ICollection<Extra> CreateExtras()
        {
            List<Extra> extras = new List<Extra>()
            {
                new Extra()
                {
                    Id = 1,
                    Name = "Driving abroad",
                    Description = "For a specific request to go abroad, you may be asked for additional information and certain restrictions may be imposed.",
                    PricePerDay = 60,
                    Discount = 0,

                },
                new Extra()
                {
                    Id = 2,
                    Name = "Mobile WiFi HOTSPOT",
                    Description = "Enjoy your stay in Bulgaria with high quality internet everywhere in the country.",
                    PricePerDay = 6,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 3,
                    Name = "Tension belt",
                    PricePerDay = 1,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 4,
                    Name = "Anti-skid snow chains",
                    Description = "One time fee for purchase of Anti-skid show chains. They remain for the client after rental.",
                    PricePerDay = 30,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 5,
                    Name = "Collision Damage Waiver (CDW)",
                    Description = "Limits your financial liability in the event of collision-related damage to the vehicle",
                    PricePerDay = 0,
                    Discount = 0,

                },
                new Extra()
                {
                    Id = 6,
                    Name = "Theft Waiver (THW)",
                    Description = "Limits your financial liability in the event of theft or attempted theft of the vehicle",
                    PricePerDay = 0,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 7,
                    Name = "Value Cover. Glass, Lights and Tyres Protection",
                    Description = "Reduces your financial liability for damage to windscreen, glass, lights and tyres up to your excess.",
                    PricePerDay = 4.54M,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 8,
                    Name = "Personal Accident Protection",
                    Description = "Provides indemnity for driver and passengers in case of death or injury and covers medical expenses.",
                    PricePerDay = 4.54M,
                    Discount = 0,
                },
                new Extra()
                {
                    Id = 9,
                    Name = "Personal belongings protection",
                    Description = "Provides indemnity for your personal belongings in case of destruction or theft.",
                    PricePerDay = 4.54M,
                    Discount = 0,
                }
                
                
            };

            return extras;
        }
    }
}
