using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class ProductDataHttp
    {
        string url = "https://localhost:44328/api/product";

        public async Task<List<Product>> getproduct()
        {
            var prod1 = new List<Product>();
            using (var httpclient = new HttpClient())
            {
                var response = await httpclient.GetAsync(url);


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var prod = JsonSerializer.Deserialize<List<Product>>(responseString,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    prod1 = prod;
                }
            }
            return prod1;
        }
    }
}
