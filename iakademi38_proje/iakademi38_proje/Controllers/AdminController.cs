using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class AdminController : Controller
    {
        Cls_User cls_User = new Cls_User();
        Cls_Category cls_Category = new Cls_Category();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        public async Task<ActionResult> CategoryIndex()
        {
            List<Category> categories = await cls_Category.CategorySelect();
            return View();
        }
    }
}