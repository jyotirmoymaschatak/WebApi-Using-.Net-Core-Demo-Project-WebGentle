using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Demo_From_WebGentle.Models;
using WebApi_Demo_From_WebGentle.Repository;

namespace WebApi_Demo_From_WebGentle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository.GetAllProducts();

            return Ok(products);
        }
        [HttpGet("")]
        public IActionResult GetName()
        {
            var name = _productRepository.GetName();
            return Ok(name);
        }
    }
}
