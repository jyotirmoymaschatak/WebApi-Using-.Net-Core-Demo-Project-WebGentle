using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo_From_WebGentle.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        public string GetAll()
        {
            return "Hello from GetAll();";
        }
        [Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from GetAllAuthors()";
        }
        [Route("books/{id?}")]
        public string GetByID(int id)
        {
            return "Hello " + id;
        }
        [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressByID(int id, int authorId)
        {
            return "Hello " + id + " "+ authorId;
        }
        [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return ("Hello from search! - id "+ id + " authorId= "+ authorId+ " name "+ name + " Rating= "+ rating + " price= "+ price);
        }
    }
}
