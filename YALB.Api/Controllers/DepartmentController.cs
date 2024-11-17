using Microsoft.AspNetCore.Mvc;
using YALB.Api.Models;

namespace YALB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public List<Department> departmentList = new List<Department>
        {
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "Finance" },
            new Department { Id = 3, Name = "HR" }
        };

        [HttpGet]
        public IActionResult GetDepartments()
        {
            return Ok(departmentList);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            return Ok(departmentList.FirstOrDefault(x => x.Id == id));
        }
    }
}
