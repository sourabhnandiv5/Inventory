using InventoryManagement.Models;
using InventoryManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ProductDataHttp prd = new ProductDataHttp();
          

            List<Product> list = await prd.getproduct();
            return View(list);

           
        }
    }
}
