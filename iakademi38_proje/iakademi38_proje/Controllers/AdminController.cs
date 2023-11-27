using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace iakademi38_proje.Controllers
{
    public class AdminController : Controller
    {

        /*
            Sql'de tablodaki kayır ID ler 1000 küsür olmasın sıralı gitsin kodu:
            
            ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF
         */

        iakademi38Context context = new iakademi38Context();
        Cls_User cls_User = new Cls_User();
        Cls_Category cls_Category = new Cls_Category();
        Cls_Supplier cls_Supplier = new Cls_Supplier();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Bind: .cshtml sayfasından gelecek olan property listesi
        // Bind dışında gelen verileri kabul etmez
        [HttpPost]
        [ValidateAntiForgeryToken] // Botlara karşı koruma
        public async Task<IActionResult> Login([Bind("Email,Password,NameSurname")] User user)
        {
            if (ModelState.IsValid)
            {
                User? usr = await cls_User.LoginController(user);
                if(usr != null)
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewBag.error = "Email ve/veya şifre yanlış";
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        // list suppliers
        public async Task<ActionResult> SupplierIndex()
        {
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();

            ViewBag.markaListesi = suppliers;

            return View(suppliers);
        }
    }
}