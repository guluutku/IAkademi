using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class StatusController : Controller
    {
        /*
        // list Status
        public async Task<ActionResult> StatusIndex()
        {
            List<Status> status = await cls_Status.StatusSelect();

            ViewBag.markaListesi = status;

            return View("~/Views/Admin/Status/StatusIndex.cshtml", status);
        }
        */

        public IActionResult StatusIndex()
        {
            return View("~/Views/Admin/Status/StatusIndex.cshtml");
        }
    }
}