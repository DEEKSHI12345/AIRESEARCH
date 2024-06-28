using BigEmployee_BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigEmployee_PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeBl _employeeBl;

        public EmployeeController(EmployeeBl employeeBl)
        {
            _employeeBl = employeeBl;
        }


        [HttpGet("{size}/{number}")]
        public IActionResult GetEmployees(int size,int number)
        {
            return Ok(_employeeBl.GetEmployees(size,number) );
        }


    }
}
