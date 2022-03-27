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
    [BindProperties]
    public class CountriesController : ControllerBase
    {
        //[BindProperty]
        //public CountryModel Country { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        [HttpPost("")]
        public IActionResult AddCountry()
        {
            //return Ok(name);
            //return Ok(this.Country.Name + " "+ this.Country.Population + " "+ this.Country.Area);
            return Ok(this.Name + " " + this.Population + " " + this.Area);
        }
        [Route("test")]
        public IActionResult TestResult()
        {
            return Ok(true);
        }
        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries);
        }
        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name="Id")]CountryModel country)
        {
            return Ok(country);
        }
    }
}
