using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iakademi38_proje.Controllers
{
    public class StatusController : Controller
    {
        Cls_Status cls_Status = new Cls_Status();
        iakademi38Context context = new iakademi38Context();

        public async Task<IActionResult> StatusIndex()
        {
            List<Status> statuses = await cls_Status.StatusSelect();
            return View("~/Views/Admin/Status/StatusIndex.cshtml", statuses);
        }

        [HttpGet]
        public IActionResult StatusCreate()
        {
            return View("~/Views/Admin/Status/StatusCreate.cshtml");
        }

        [HttpPost]
        public IActionResult StatusCreate(Status status)
        {
            bool answer = cls_Status.StatusInsert(status);
            if (answer)
            {
                TempData["Message"] = "Eklendi";
            }
            else
            {
                TempData["Message"] = " HATA";
            }
            return RedirectToAction(nameof(StatusCreate));
        }

        [HttpGet]
        public async Task<IActionResult> StatusEdit(int? id)
        {
            if (id == null || context.Statues == null)
            {
                return NotFound();
            }

            var status = await cls_Status.StatusDetails(id);

            return View("~/Views/Admin/Status/StatusEdit.cshtml", status);
        }

        [HttpPost]
        public IActionResult StatusEdit(Status status)
        {
            bool answer = Cls_Status.StatusUpdate(status);
            if (answer)
            {
                TempData["Message"] = "Güncellendi";
                return RedirectToAction("StatusIndex.cshtml");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(StatusEdit));
            }
        }

        [HttpGet]
        public async Task<IActionResult> StatusDelete(int? id)
        {
            if (id == null || context.Statues == null)
            {
                return NotFound();
            }
            var Status = await context.Statues.FirstOrDefaultAsync(s => s.StatusID == id);

            if (Status == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Status/StatusDelete.cshtml", Status);
        }

        // Url'de ActionName yazıyor
        [HttpPost, ActionName("StatusDelete")]
        public IActionResult StatusDeleteConfirmed(int id)
        {
            bool answer = Cls_Status.StatusDelete(id);
            if (answer == true)
            {
                TempData["Message"] = "SİLİNDİ";
                return RedirectToAction("StatusIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(StatusDelete));
            }

        }
    }
}