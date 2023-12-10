using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace iakademi38_proje.Controllers
{
    public class ProductController : Controller
    {

        Cls_Product cls_Product = new Cls_Product();
        Cls_Category cls_Category = new Cls_Category();
        Cls_Supplier cls_Supplier = new Cls_Supplier();
        Cls_Status cls_Status = new Cls_Status();

        public async Task<IActionResult> ProductIndex()
        {
            List<Product> products = await cls_Product.ProductSelect();
            return View("~/Views/Admin/Product/ProductIndex.cshtml", products);
        }
        
        // Create Product
        [HttpGet]
        public async Task<IActionResult> ProductCreate()
        {
            List<Category> categories = await cls_Category.CategorySelect();
            ViewData["categoryList"] = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName, Value = c.CategoryID.ToString()
            });
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();
            ViewData["supplierList"] = suppliers.Select(s => new SelectListItem
            {
                Text = s.BrandName,
                Value = s.SupplierID.ToString()
            });

            List<Status> statuses = await cls_Status.StatusSelect();
            ViewData["statusList"] = statuses.Select(st => new SelectListItem
            {
                Text = st.StatusName,
                Value = st.StatusID.ToString()
            });

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