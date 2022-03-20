using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IProducts
    {
        Task<List<Product>> GetProducts();
    }
}
