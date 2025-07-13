using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApiHandson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "Finance", Salary = 60000 },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 70000 }
        };

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Invalid employee id");

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;

            return Ok(employee);
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee newEmployee)
        {
            newEmployee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(newEmployee);
            return CreatedAtAction(nameof(UpdateEmployee), new { id = newEmployee.Id }, newEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound("Employee not found");

            employees.Remove(employee);
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
    }
}
