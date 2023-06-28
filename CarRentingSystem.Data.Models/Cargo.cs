using CarRentingSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarRentingSystem.Common.EntityValidationConstants.Cargo;

namespace CarRentingSystem.Data.Models
{
    public class Cargo
    {
        public Cargo()
        {
            IsAvailable = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [MaxLength(ModelMaxLength)]
        public string? Model { get; set; }

        [Required]
        [Range(MaxWeightCapacityMinValue, MaxWeightCapacityMaxValue)]
        public int MaxWeightCapacity { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public bool IsAvailable { get; set; }

        [Required]
        public string Category { get; set; }

        [ForeignKey(nameof(ProtectionPlan))]
        public int? ProtectionPlanId { get; set; }

        public ProtectionPlan? ProtectionPlan { get; set; }
    }
}
