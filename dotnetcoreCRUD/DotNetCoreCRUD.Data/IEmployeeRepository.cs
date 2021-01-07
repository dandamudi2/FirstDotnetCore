using DotNetCoreCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreCRUD.Data
{
    public  interface IEmployeeRepository
    {
         Employee AddEmployee(Employee employee);

        IEnumerable<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);


        Employee GetEmployeedOnId(int id);

        void DeleteEmployee(int id);
    }
}
