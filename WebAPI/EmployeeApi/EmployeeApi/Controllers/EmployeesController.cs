using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 60000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 75000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 70000 }
        };

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updated)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existing = Employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
            {
                return BadRequest("Invalid employee id");
            }

            existing.Name = updated.Name;
            existing.Department = updated.Department;
            existing.Salary = updated.Salary;

            return Ok(existing);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll() => Ok(Employees);
    }
}