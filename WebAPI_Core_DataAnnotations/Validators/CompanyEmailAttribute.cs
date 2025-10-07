using System.ComponentModel.DataAnnotations;

namespace WEBAPI_Core_DataAnnotations.Validators
{
    public class CompanyEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Email is required.");

            string email = value.ToString();

            if (email.EndsWith("@encora.com", StringComparison.OrdinalIgnoreCase))
            {
                return ValidationResult.Success; // Valid email
            }

            return new ValidationResult("Email must end with @encora.com");
        }
    }
}
