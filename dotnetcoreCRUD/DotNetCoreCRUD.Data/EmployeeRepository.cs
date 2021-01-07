using DotNetCoreCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreCRUD.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext employeeDbContext;

        public EmployeeRepository(EmployeeDBContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employeeDbContext.Employees.Add(employee);
            employeeDbContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
           Employee employee=  employeeDbContext.Employees.Find(id);

            employeeDbContext.Employees.Remove(employee);
            employeeDbContext.SaveChanges();
        }

        public Employee GetEmployeedOnId(int id)
        {
            return employeeDbContext.Employees.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
           return  employeeDbContext.Employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDbContext.Entry(employee).State = EntityState.Modified;
            employeeDbContext.SaveChanges();
        }
    }
}
