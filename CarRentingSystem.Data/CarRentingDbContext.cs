using CarRentingSystem.Data.Configurations;
using CarRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentingSystem.Web.Data
{
    public class CarRentingDbContext : IdentityDbContext<IdentityUser>
    {
        public CarRentingDbContext(DbContextOptions<CarRentingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Cargo> Cargos { get; set; } = null!;
        public DbSet<Extra> Extras { get; set; } = null!;
        public DbSet<ProtectionPlan> ProtectionPlans { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarEntityConfiguration());
            builder.ApplyConfiguration(new CargoEntityConfiguration());
            builder.ApplyConfiguration(new ExtraEntityConfiguration());
            builder.ApplyConfiguration(new ProtectionPlanEntityConfiguration());
            base.OnModelCreating(builder);
        }
    }
}