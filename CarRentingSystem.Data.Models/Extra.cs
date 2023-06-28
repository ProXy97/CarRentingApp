using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Common.EntityValidationConstants.Extras;
namespace CarRentingSystem.Data.Models
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        [Range(PricePerDayMinValue, PricePerDayMaxValue)]
        public decimal? PricePerDay { get; set; }

        [Range(DiscountMinValue, DiscountMaxValue)]
        public double Discount { get; set; }
    }
}
