using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace iakademi38_proje.Controllers
{
    public class AdminController : Controller
    {

        /*
            Sql'de tablodaki kayır ID ler 1000 küsür olmasın sıralı gitsin kodu:
            
            ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF
         */

        Cls_User cls_User = new Cls_User();
        Cls_Category cls_Category = new Cls_Category();
        iakademi38Context context = new iakademi38Context();

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
                Text = c.CategoryName,
                Value = c.CategoryID.ToString()
            });
        }

        [HttpPost]
        public IActionResult CategoryCreate(Category category)
        {
            bool answer = Cls_Category.CategoryInsert(category);
            if (answer == true)
            {
                TempData["Message"] = "Eklendi";
            }
            else
            {
                TempData["Message"] = "HATA";
            }
            return RedirectToAction(nameof(CategoryCreate));
        }

        [HttpGet]
        public async Task<IActionResult> CategoryEdit(int? id)
        {
            CategoryFill();
            if(id == null || context.Categories == null)
            {
                return NotFound();
            }

            var category = await cls_Category.CategoryDetails(id);
            return View(category);

        }

        [HttpGet]
        public IActionResult CategoryEdit(Category category)
        {
            bool answer = Cls_Category.CategoryUpdate(category);
            if(answer == true)
            {
                TempData["Message"] = "Güncellendi";
                return RedirectToAction("CategoryIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(CategoryEdit));
            }

        }
    }
}