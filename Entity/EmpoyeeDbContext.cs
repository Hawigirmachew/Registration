using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    // to create tables
    public class EmpoyeeDbContext:DbContext
    {
        // constructor 
        public EmpoyeeDbContext(DbContextOptions<EmpoyeeDbContext> options):base(options)
        {
        }
        // methods- are going to change to tables
        // we used Dbset to configure as table in sql
        // generic types can accept any kind of datatypes
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set;}
    }
}
