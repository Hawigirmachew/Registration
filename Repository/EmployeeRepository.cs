namespace Repository;

using Entity;
using Contracts;
using Microsoft.EntityFrameworkCore;



    public class EmployeeRepository:IEmployees
    {

        private readonly EmpoyeeDbContext _dbContext;
        public EmployeeRepository(EmpoyeeDbContext dbContext) {
           _dbContext = dbContext;
        }

        public int Create(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee.id;
        }
        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }
    public async Task<Employee> GetById(int id)
    {
        if (_dbContext.Employees == null)
        {
            return null;
        }
        var emp = await _dbContext.Employees.FindAsync(id);

        if (emp == null)
        {
            return null;
        }

        return emp;
    }
      public bool UpdateEmployee(int id, Employee employee)
      {
        var update = _dbContext.Employees.Find(id);
        if (employee.id == id)
        {
            update.fName = employee.fName;
            update.lName = employee.lName;
            update.address = employee.address;
            _dbContext.Employees.Update(update);
            _dbContext.SaveChanges();
            return true;

        }
        return false;
      }

     public async Task<Employee> DeleteEmployee(int id)
    {
        if (_dbContext.Employees == null)
        {
            return null;
        }
        var emp = await _dbContext.Employees.FindAsync(id);

        if (emp == null)
        {
            return null;
        }
        _dbContext.Employees.Remove(emp);
        _dbContext.SaveChanges();
        return null;
    }


}
