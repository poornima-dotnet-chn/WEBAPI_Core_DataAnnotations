using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI_Core_DataAnnotations.Models;

namespace WebAPI_Core_DataAnnotations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            // ModelState automatically validates based on DataAnnotations
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Normally, you'd save to the database here
            return Ok(new { message = "Employee created successfully!", data = employee });
        }
    }
}
