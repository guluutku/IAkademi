using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class SupplierController : Controller
    {
        Cls_Supplier cls_Supplier = new Cls_Supplier();

        // list suppliers
        public async Task<ActionResult> SupplierIndex()
        {
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();

            ViewBag.markaListesi = suppliers;

            return View("~/Views/Admin/Supplier/SupplierIndex.cshtml", suppliers);
        }
    }
}