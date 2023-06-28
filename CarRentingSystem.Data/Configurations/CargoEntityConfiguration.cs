using CarRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarRentingSystem.Data.Models.Enums;
namespace CarRentingSystem.Data.Configurations
{
    public class CargoEntityConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            ICollection<Cargo> cargos = CreateCargos();
            builder.HasData(cargos);
        }

        private ICollection<Cargo> CreateCargos()
        {
            List<Cargo> cargos = new List<Cargo>()
            {
                new Cargo()
                {
                  Id = 1,
                  Make = CargoMakeType.Mercedes.ToString(),
                  Model = "Sprinter",
                  MaxWeightCapacity = 3750,
                  ImagePath = "/img/Cargos/Mercedes Cargo.png",
                  Category = CargoCategoryType.Van.ToString(),
                  Description = "The award-winning van that continues to lead the way for large vans - the Sprinter Panel Van boasts the highest standard specification of any large van. Take your business to the next level."
                },
            };
            return cargos;
        }
    }
}
