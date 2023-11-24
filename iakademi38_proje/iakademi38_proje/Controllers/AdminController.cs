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

        public async Task<ActionResult> CategoryIndex()
        {
            List<Category> categories = await cls_Category.CategorySelect();

            ViewBag.kategoriListesi = categories;

            return View(categories);
        }

        [HttpGet]
        public IActionResult CategoryCreate()
        {
            CategoryFill();
            return View();
        }

        void CategoryFill()
        {
            List<Category> categories = cls_Category.CategorySelectMain();
            ViewData["categoryList"] = categories.Select(c => new SelectListItem
            {
                TextReader = c.CategoryName, ValueTask = c.CategoryID.ToString()
            });
        }
    }
}