using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class ProductController : Controller
    {

        Cls_Product cls_Product = new Cls_Product();

        public async Task<IActionResult> ProductIndex()
        {
            List<Product> products = await cls_Product.ProductSelect();
            return View("~/Views/Admin/Product/ProductIndex.cshtml", products);
        }
        
        // Create Product
        [HttpGet]
        public IActionResult ProductCreate()
        {
            return View("~/Views/Admin/Product/ProductCreate.cshtml");
        }
        
        [HttpPost]
        public IActionResult ProductCreate(Product Product)
        {
            bool answer = Cls_Product.ProductInsert(Product);
            if (answer == true)
            {
                TempData["Message"] = "Eklendi";
            }
            else
            {
                TempData["Message"] = "HATA";
            }
            return RedirectToAction(nameof(ProductCreate));
        }
    }
}