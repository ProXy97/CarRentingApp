using CarRentingSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarRentingSystem.Common.EntityValidationConstants.ProtectionPlans;

namespace CarRentingSystem.Data.Models
{
    public class ProtectionPlan
    {

        public ProtectionPlan()
        {
            this.Cars = new HashSet<Car>();
            this.Cargos = new HashSet<Cargo>();
            this.Extras = new HashSet<Extra>();
        }

        [Key]
        public int Id { get; set; }

        [Range(PricePerDayMinValue, PricePerDayMaxValue)]
        public decimal PricePerDay { get; set; }

        [Range(DiscountMinValue, DiscountMaxValue)]
        public double? Discount { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public string ProtectionType { get; set; }

        public virtual ICollection<Extra> Extras { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<Cargo> Cargos { get; set; }

    }
}
