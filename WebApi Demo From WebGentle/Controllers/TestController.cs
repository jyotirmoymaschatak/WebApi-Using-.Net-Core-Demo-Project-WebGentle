using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo_From_WebGentle.Controllers
{
    [ApiController]
    //[Route("test/action")]
    public class TestController : Controller
    {
        [Route("test")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("test/get")]
        public string Get()
        {
            return "Hello from test controller";
        }
    }
}
