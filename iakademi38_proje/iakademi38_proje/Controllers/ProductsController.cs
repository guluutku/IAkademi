using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductsIndex()
        {
            return View("~/Views/Admin/Products/ProductsIndex.cshtml");
        }
    }
}