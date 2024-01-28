using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Yayinlama_Products.Controllers
{
    [Route("aip/[controller]")]
    [ApiController]
    public class ProdcutController : ControllerBase
    {

        NorthwindContext northwindContext = new NorthwindContext();

        // method [HttpGet] veya ismi Get ile başlamak zorundadır
        [HttpGet]
        public List<Product> UrunleriGetir()
        {
            List<Product> products = northwindContext.Products.ToList();
            return products;
        }
    }
}