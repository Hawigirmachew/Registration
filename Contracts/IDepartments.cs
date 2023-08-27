using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Contracts
{
    public interface IDepartements

    {
        public int CreateDepartment(Department department);
        public List<Department> GetAllDep();
        public Task<Department> GetDepById(int id);
       
        public bool UpdateDepartment(int id, Department department);

        public bool DeleteDepartment(int id);
    }
}
