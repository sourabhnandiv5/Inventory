using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        readonly IProducts prdt;
        public ProductController(IProducts _prdt)
        {
            prdt = _prdt;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            //return NotFound();
            //return new List<Person>() { new Person() { Id = 1, Name = "Felipe"},
            //new Person(){Id = 2, Name = "Claudia"}};
            return await prdt.GetProducts();
        }




    }
}
