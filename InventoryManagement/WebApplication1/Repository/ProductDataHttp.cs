using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class ProductDataHttp
    {
        string url = "https://localhost:44300/api/product";

        public async void getproduct()
        {
            using (var httpclient = new HttpClient())
            {
             var data =  await  httpclient.GetStringAsync(url);
            }
        }
    }
}
