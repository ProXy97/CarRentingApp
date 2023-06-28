using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Common
{
    public static class EntityValidationConstants
    {
        public static class Car
        {
            public const int MakeMinLength = 2;
            public const int MakeMaxLength = 20;

            public const int ModelMinLength = 2;
            public const int ModelMaxLength = 20;

            public const int ImageUrlMinLength = 10;
            public const int ImageUrlMaxLength = 2048;

            public const int YearMinValue = 1940;
            public const int YearMaxValue = 2023;

            public const int MinAgeRequiredMinValue = 18;
            public const int MinAgeRequiredMaxValue = 85;
        }

        public static class Cargo
        {
            public const int ModelMinLength = 2;
            public const int ModelMaxLength = 20;

            public const int ImageUrlMinLength = 10;
            public const int ImageUrlMaxLength = 2048;

            public const int MaxWeightCapacityMinValue = 1000;
            public const int MaxWeightCapacityMaxValue = 10000;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
        }

        public static class CarCategory
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }

        public static class User
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 30;

            public const int AgeMinValue = 0;
            public const int AgeMaxValue = 100;

            public const int AddressMinLength = 10;
            public const int AddressMaxLength = 100;

            public const int DriverLicenseMinLength = 8;
            public const int DriverLicenseMaxLength = 20;
        }

        public static class Extras
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const double PricePerDayMinValue = 0.01;
            public const double PricePerDayMaxValue = 999.00;

            public const double DiscountMinValue = 0.00;
            public const double DiscountMaxValue = 99.99;
        }

        public static class ProtectionPlans
        {
            public const double PricePerDayMinValue = 0.01;
            public const double PricePerDayMaxValue = 9999.00;

            public const double DiscountMinValue = 0.00;
            public const double DiscountMaxValue = 99.99;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 1000;
        }

       

    }
}
