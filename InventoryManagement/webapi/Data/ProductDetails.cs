using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ProductDetails : IProducts
    {
        readonly ProductDbContext dbcontext;
        public ProductDetails(ProductDbContext _dbcontext)
        {
            dbcontext = _dbcontext;

        }
       
        public async Task<List<Product>> GetProducts()
        {
            //return NotFound();
            //return new List<Person>() { new Person() { Id = 1, Name = "Felipe"},
            //new Person(){Id = 2, Name = "Claudia"}};
            return await  dbcontext.Product.ToListAsync();
        }

       
    }
}
