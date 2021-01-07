using DotNetCoreCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCoreCRUD.Data
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
