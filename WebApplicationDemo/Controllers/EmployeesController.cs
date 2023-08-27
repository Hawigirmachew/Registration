using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;

// routing is defined here
namespace WebApplicationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees _employeeService;

        public EmployeesController(IEmployees employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public int Create(Employee employee)
        {
            return _employeeService.Create(employee);
        }
       [HttpGet("{id}")]
        public Task<Employee> GetById(int id)
        {
        return _employeeService.GetById(id);

        }
        [HttpGet]
        public List<Employee> GetAll()
        {
            return _employeeService.GetAll();
        }
        [HttpPut("{id}")]
        public bool UpdateEmployee(int id, Employee employee)
        {
            return _employeeService.UpdateEmployee(id, employee);   
        }

        [HttpDelete("{id}")]
        public Task<Employee> DeleteEmployee(int id)
        {
            return _employeeService.DeleteEmployee(id);
        }

    }


}
