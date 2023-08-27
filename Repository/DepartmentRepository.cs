using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entity;

namespace Repository
{
    public class DepartmentRepository:IDepartements
    {
        private readonly EmpoyeeDbContext _dbContext;
        public DepartmentRepository(EmpoyeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();
            return department.id;
        }

        public List<Department> GetAllDep()
        {
            return _dbContext.Departments.ToList();
        }

        public async Task<Department> GetDepById(int id)
        {
            if (_dbContext.Departments == null)
            {
                return null;
            }
            var department = await _dbContext.Departments.FindAsync(id);

            if (department == null)
            {
                return null;
            }

            return department;
        }

        public bool UpdateDepartment(int id, Department department)
        {
            var update = _dbContext.Departments.Find(id);
            if (department.id == id)
            {
                update.name = department.name;
               
                _dbContext.Departments.Update(update);
                _dbContext.SaveChanges();
                return true;

            }
            return false;
        }
        public bool  DeleteDepartment(int id){
            var existing =  _dbContext.Departments.Find(id);

            _dbContext.Departments.Remove(existing);

            _dbContext.SaveChanges();

            return true;
        }

    }
}
