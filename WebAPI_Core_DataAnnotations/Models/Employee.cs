using System.ComponentModel.DataAnnotations;
using WEBAPI_Core_DataAnnotations.Validators;

namespace WEBAPI_Core_DataAnnotations.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
       [CompanyEmailAttribute]
        public string Email { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(10000, 200000, ErrorMessage = "Salary must be between 10,000 and 200,000.")]
        public decimal Salary { get; set; }
    }
}
