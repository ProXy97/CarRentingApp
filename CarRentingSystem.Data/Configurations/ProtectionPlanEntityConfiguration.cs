using CarRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarRentingSystem.Data.Models.Enums;
using System.Net;

namespace CarRentingSystem.Data.Configurations
{
    public class ProtectionPlanEntityConfiguration : IEntityTypeConfiguration<ProtectionPlan>
    {
        public void Configure(EntityTypeBuilder<ProtectionPlan> builder)
        {
            ICollection<ProtectionPlan> plans = CreatePlans();
            builder.HasData(plans);
        }

        private List<ProtectionPlan> CreatePlans()
        {
            List<ProtectionPlan> plans = new List<ProtectionPlan>()
            {
                new ProtectionPlan()
                {
                    Id = 1,
                    PricePerDay = 0.00M,
                    Description = "Basic Plan",
                    ProtectionType = ProtectionType.Basic.ToString(),
                    
                },
                new ProtectionPlan()
                {
                    Id = 2,
                    PricePerDay = 8.58M,
                    Description = "Medium Plan",
                    ProtectionType = ProtectionType.Medium.ToString()
                },
                new ProtectionPlan()
                {
                    Id = 3,
                    PricePerDay = 12.88M,
                    Description = "Premium Plan",
                    ProtectionType = ProtectionType.Premium.ToString()
                }
            };

            return plans;
        }
    }
}
