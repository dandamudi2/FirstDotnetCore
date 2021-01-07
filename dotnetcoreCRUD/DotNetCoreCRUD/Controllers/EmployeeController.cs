using DotNetCoreCRUD.Data;
using DotNetCoreCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
           
            return Ok(employeeRepository.GetEmployees());
        }

        [HttpPost]
        [Route("SaveEmployee")]
        public IActionResult SaveEmployee(Employee employee)
        {
            employee= employeeRepository.AddEmployee(employee);
            return Ok(employee);
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(employeeRepository.GetEmployeedOnId(id));
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            employeeRepository.UpdateEmployee(employee);
            return Ok(new  { employee });
        }

        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            employeeRepository.DeleteEmployee(id);
            return Ok("");
        }

      
    }
}
