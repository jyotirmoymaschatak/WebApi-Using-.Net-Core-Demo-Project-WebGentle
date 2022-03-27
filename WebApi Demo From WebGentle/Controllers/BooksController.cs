using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo_From_WebGentle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int}")]
        public string GetById(int id) //expecting int
        {
            return "hello int " + id;
        }
        [Route("{id}")]
        public string GetById(string id) //expecting string 
        {
            return "hello string " + id;
        }
    }
}
