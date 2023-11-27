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

        // list categories
        public async Task<ActionResult> CategoryIndex()
        {
            List<Category> categories = await cls_Category.CategorySelect();

            ViewBag.kategoriListesi = categories;

            return View(categories);
        }

        // Create Category
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

        // Edit categories
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

        [HttpPost]
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

        // Check category details
        [HttpGet]
        public async Task<IActionResult> CategoryDetails(int? id)
        {
            var catergory = await context.Categories.FirstOrDefaultAsync(context => context.CategoryID == id);
            ViewBag.categoryname = catergory?.CategoryName;

            return View(catergory);
        }

        // Delete category
        [HttpGet]
        public async Task<IActionResult> CategoryDelete(int? id)
        {
            if(id == null || context.Categories == null)
            {
                return NotFound();
            }

            var category = await context.Categories.FirstOrDefaultAsync(c => c.CategoryID == id);

            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("CategoryDelete")]
        public IActionResult CategoryDeleteConfirmed(int id)
        {
            bool answer = Cls_Category.CategoryDelete(id);
            if (answer == true)
            {
                TempData["Message"] = "SİLİNDİ";
                return RedirectToAction("CategoryIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(CategoryDelete));
            }

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