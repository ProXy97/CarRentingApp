using CarRentingSystem.Data.Models;
using CarRentingSystem.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentingSystem.Data.Configurations
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasOne(c => c.ProtectionPlan).WithMany(pp => pp.Cars).HasForeignKey(c => c.ProtectionPlanId).OnDelete(DeleteBehavior.Restrict);

            ICollection<Car> cars = CreateCars();
            builder.HasData(cars);
        }

        private ICollection<Car> CreateCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    Make = CarMake.Audi.ToString(),
                    Model = "A6",
                    ImageUrl = "https://imgd.aeplcdn.com/370x208/n/cw/ec/39472/a6-exterior-right-front-three-quarter.jpeg?q=75",
                    Year = 2022,
                    MinAgeRequired = 28,
                    PricePerDay = 199.99M,
                    PeopleCapacity = 5,
                    Power = 333,
                    Emissions = 120,
                    Location = "Sofia",
                    CategoryType = CarCategoryType.Luxury.ToString(),
                    Transmission = TransmissionType.Automatic.ToString(),
                    Description = "Performance. Efficiency. Design. This is Audi Innovation. Sophistication in every detail."
                },
                new Car()
                {
                    Id = 2,
                    Make = CarMake.Audi.ToString(),
                    Model = "A4",
                    ImageUrl = "https://www.motortrend.com/uploads/sites/10/2020/12/2021-audi-a4-premium-sedan-angular-front.png",
                    Year = 2021,
                    MinAgeRequired = 28,
                    PricePerDay = 179.99M,
                    PeopleCapacity = 5,
                    Power = 170,
                    Emissions = 80,
                    Location = "Sofia",
                    CategoryType = CarCategoryType.Luxury.ToString(),
                    Transmission = TransmissionType.Automatic.ToString(),
                    Description = "Performance. Efficiency. Design. This is Audi Innovation. Sophistication in every detail."
                },
                new Car()
                {
                    Id = 3,
                    Make = CarMake.BMW.ToString(),
                    Model = "520d",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTy8W7qHiL69C8N-v0y_3xIM1jwkrBpKrVuVw&usqp=CAU",
                    Year = 2021,
                    MinAgeRequired = 28,
                    PricePerDay = 199.99M,
                    PeopleCapacity = 5,
                    Power = 170,
                    Emissions = 80,
                    Location = "Plovdiv",
                    CategoryType = CarCategoryType.Luxury.ToString(),
                    Transmission = TransmissionType.Automatic.ToString(),
                    Description = "The BMW 520d 2021 is a luxury sedan that combines elegance and performance. It features a powerful yet efficient diesel engine, delivering a smooth and dynamic driving experience. With its sleek design, advanced technology, and comfortable interior, it offers a perfect blend of style, comfort, and sophistication."
                },
                 new Car()
                {
                    Id = 4,
                    Make = CarMake.Renault.ToString(),
                    Model = "Clio",
                    ImageUrl = "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1649084579/autoexpress/2022/04/Renault%20Clio%202022.jpg",
                    Year = 2022,
                    MinAgeRequired = 22,
                    PricePerDay = 49.99M,
                    PeopleCapacity = 4,
                    Power = 70,
                    Emissions = 30,
                    Location = "Plovdiv",
                    CategoryType = CarCategoryType.Small.ToString(),
                    Transmission = TransmissionType.Manual.ToString(),
                    Description = "Stylish and compact hatchback that offers a perfect balance of performance, efficiency, and modern features, making it a practical and enjoyable urban companion."
                },
                 new Car()
                {
                    Id = 5,
                    Make = CarMake.Volkswagen.ToString(),
                    Model = "Passat",
                    ImageUrl = "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1563183024/autoexpress/2019/02/01_7.jpg",
                    Year = 2019,
                    MinAgeRequired = 22,
                    PricePerDay = 89.99M,
                    PeopleCapacity = 5,
                    Power = 140,
                    Emissions = 65,
                    Location = "Bourgas",
                    CategoryType = CarCategoryType.Medium.ToString(),  
                    Transmission = TransmissionType.Automatic.ToString(),
                    Description = "Reliable and spacious mid-size sedan, known for its comfortable ride, premium interior, advanced safety features, and fuel-efficient engine options, making it a versatile family car."
                },
            };

            return cars;
        }
    }
}
