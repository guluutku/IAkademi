using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult SettingsIndex()
        {
            return View("~/Views/Admin/Settings/SettingsIndex.cshtml");
        }
    }
}