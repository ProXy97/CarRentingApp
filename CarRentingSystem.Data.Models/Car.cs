using CarRentingSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Common.EntityValidationConstants.Car;

namespace CarRentingSystem.Data.Models
{
    public class Car
    {

        public Car()
        {
            IsAvailable = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Range(YearMinValue, YearMaxValue)]
        public int Year { get; set; }

        [Range(MinAgeRequiredMinValue, MinAgeRequiredMaxValue)]
        public int MinAgeRequired { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }
        public int PeopleCapacity { get; set; }
        public int Power { get; set; }

        public int Emissions { get; set; }

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string CategoryType { get; set; } = null!;

        [Required]
        public string Transmission { get; set; } = null!;
    
        public string Description { get; set; } = null!;
    }
}
