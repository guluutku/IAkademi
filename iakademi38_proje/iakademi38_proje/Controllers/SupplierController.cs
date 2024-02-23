using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult> SupplierEdit(int? id)
        {
            if(id == null || context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await cls_Supplier.SupplierDetails(id);

            return View("~/Views/Admin/Supplier/SupplierEdit.cshtml", supplier);
        }

        [HttpPost]
        public async Task<IActionResult> SupplierEdit(Supplier supplier)
        {
            if(supplier.PhotoPath == null)
            {
                string? PhotoPath = context.Suppliers.FirstOrDefault(s => s.SupplierID == supplier.SupplierID).PhotoPath;

                supplier.PhotoPath = PhotoPath;
            }

            bool answer = Cls_Supplier.SupplierUpdate(supplier);
            if (answer)
            {
                TempData["Message"] = "Güncellendi";
                return RedirectToAction("SupplierIndex.cshtml");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(SupplierEdit));
            }
        }

        [HttpGet]
        public async Task<IActionResult> SupplierDetails(int? id)
        {
            var supplier = await context.Suppliers.FirstOrDefaultAsync(s => s.SupplierID == id);
            ViewBag.brandName = supplier?.BrandName;

            return View("~/Views/Admin/Supplier/SupplierDetails.cshtml", supplier);
        }

        [HttpGet]
        public async Task<IActionResult> SupplierDelete(int? id)
        {
            if (id == null || context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await context.Suppliers.FirstOrDefaultAsync(s => s.SupplierID == id);

            if (supplier == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Supplier/SupplierDelete.cshtml", supplier);
        }

        // Url'de ActionName yazıyor
        [HttpPost, ActionName("SupplierDelete")]
        public IActionResult SupplierDeleteConfirmed(int id)
        {
            bool answer = Cls_Supplier.SupplierDelete(id);
            if (answer == true)
            {
                TempData["Message"] = "SİLİNDİ";
                return RedirectToAction("SupplierIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(SupplierDelete));
            }

        }
    }
}