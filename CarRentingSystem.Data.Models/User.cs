using CarRentingSystem.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Common.EntityValidationConstants.User;

namespace CarRentingSystem.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.RentedCars = new HashSet<Car>();
            this.Id = Guid.NewGuid();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxNameLength)]
        public string LastName { get; set; } = null!;

        [Range(AgeMinValue, AgeMaxValue)]
        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - DateOfBirth.Year;

                if (currentDate.Month < DateOfBirth.Month || (currentDate.Month == DateOfBirth.Month && currentDate.Day < DateOfBirth.Day))
                {
                    age--;
                }

                return age;
            }
            set
            {
                Age = value;
            }
        }

        [Required]
        [DateRange("01/01/1914", ErrorMessage = "Date of Birth Must be between 01-01-1914 and Current Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [MaxLength(DriverLicenseMaxLength)]
        public string? DriverLicenseNumber { get; set; }

        public virtual ICollection<Car> RentedCars { get; set; }
    }
}
