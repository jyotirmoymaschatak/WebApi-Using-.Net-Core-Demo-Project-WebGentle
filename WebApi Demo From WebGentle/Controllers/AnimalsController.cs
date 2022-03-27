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
    public class AnimalsController : ControllerBase
    {
        [Route("")]
        public IActionResult GetAnimals()
        {
            var animals = new List<AnimalModel>()
            { 
                new AnimalModel() {Id=1, Name="Dog"},
                new AnimalModel() {Id=2, Name="Monkey"}
            };
            return Ok(animals);
        }
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id=1, Name="Dog"},
                new AnimalModel() {Id=2, Name="Cat"}
            };
            //return Accepted(animals);
            return AcceptedAtAction("GetAnimals");
        }
    }
}
