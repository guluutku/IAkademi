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
        iakademi38Context context = new iakademi38Context();

        // list suppliers
        public async Task<ActionResult> SupplierIndex()
        {
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();

            return View("~/Views/Admin/Supplier/SupplierIndex.cshtml", suppliers);
        }

        [HttpGet]
        public IActionResult SupplierCreate()
        {
            return View("~/Views/Admin/Supplier/SupplierCreate.cshtml");
        }

        [HttpPost]
        public IActionResult SupplierCreate(Supplier supplier)
        {
            bool answer = cls_Supplier.SupplierInsert(supplier);
            if (answer)
            {
                TempData["Message"] = "Eklendi";
            }
            else
            {
                TempData["Message"] = " HATA";
            }
            return RedirectToAction(nameof(SupplierCreate));
        }

        public async Task<IActionResult> SupplierEdit(int? id)
        {
            if(id == null || context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await cls_Supplier.SupplierDetails(id);

            return View("~/Views/Admin/Supplier/SupplierEdit.cshtml", supplier);
        }
    }
}