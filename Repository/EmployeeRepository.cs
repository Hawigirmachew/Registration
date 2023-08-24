namespace Repository;
using Contracts;
using Entity;
using System.Collections.Generic;
// contains the main business logic of the system

public class EmployeeRepository : IEmployees
{
    //
    private readonly EmpoyeeDbContext _dbContext;
    // constructor
    public EmployeeRepository(EmpoyeeDbContext dbContext)
    {

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
}