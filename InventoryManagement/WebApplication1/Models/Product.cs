using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string product_name { get; set; }
        public string product_desc { get; set; }
        public string product_category { get; set; }
        public bool product_avilability { get; set; }
    }
}
