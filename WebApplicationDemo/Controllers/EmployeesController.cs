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
        [HttpGet]
        public List<Employee> GetAll()
        {
            return _employeeService.GetAll();
        }
    }

    
}
