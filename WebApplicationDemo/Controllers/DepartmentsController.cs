using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entity;
using Contracts;

namespace WebApplicationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartements _departmentService;
        public DepartmentsController(IDepartements departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpPost]
        public int CreateDepartment(Department department)
        {
            return _departmentService.CreateDepartment(department);
        }

        [HttpGet]
        public List<Department> GetAllDep()
        {
            return _departmentService.GetAllDep();
        }
        [HttpGet("{id}")]
        public Task<Department> GetDepById(int id)
        {
            return _departmentService.GetDepById(id);
        }
        [HttpPut("{id}")]
        public bool UpdateDepartment(int id, Department department)
        {
            return _departmentService.UpdateDepartment(id, department);
        }

        [HttpDelete("{id}")]
        public bool DelteDepartemt(int id)
        {
            return _departmentService.DeleteDepartment(id);
        }
    }
}
