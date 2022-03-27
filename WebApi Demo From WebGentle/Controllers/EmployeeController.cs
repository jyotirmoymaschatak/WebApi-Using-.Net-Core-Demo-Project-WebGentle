using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Demo_From_WebGentle.Models;

namespace WebApi_Demo_From_WebGentle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[Route("GetEmployee")]
        //public EmployeeModel GetEmployee()
        //{
        //    return new EmployeeModel { Id = 1, Name = "Jyotirmoy" };
        //}
        [Route("GetEmployees")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>
            {
            new EmployeeModel() { Id = 1, Name = "Jyotirmoy" },
            new EmployeeModel() { Id = 2, Name = "Maschatak" }
            };
        }
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if(id==0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>
            {
            new EmployeeModel() { Id = 1, Name = "Jyotirmoy" },
            new EmployeeModel() { Id = 2, Name = "Maschatak" }
            });
        }
        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>
            {
            new EmployeeModel() { Id = 1, Name = "Jyotirmoy" }
            });
        }
    }
}
