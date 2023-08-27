using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

// interfaces are only used to declare methods and use to methods in other classes
namespace Contracts
{
    public interface IEmployees
    {
        // to post the data from the db
        public int Create(Employee employee);
        // to get the data from db
        public List<Employee> GetAll();

        //public Employee GetById(int id);
        public Task<Employee> GetById(int id);

        public bool UpdateEmployee(int id, Employee employee);
        public Task<Employee> DeleteEmployee(int id);
        
    }
}
