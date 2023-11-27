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
    public class CategoryController : Controller
    {
        iakademi38Context context = new iakademi38Context();
        Cls_User cls_User = new Cls_User();
        Cls_Category cls_Category = new Cls_Category();

        // list categories
        public async Task<ActionResult> CategoryIndex()
        {
            List<Category> categories = await cls_Category.CategorySelect();

            ViewBag.kategoriListesi = categories;

            return View("~/Views/Admin/Category/CategoryIndex.cshtml", categories);
        }

        // Create Category
        [HttpGet]
        public IActionResult CategoryCreate()
        {
            CategoryFill();
            return View("~/Views/Admin/Category/CategoryCreate.cshtml");
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
            if (id == null || context.Categories == null)
            {
                return NotFound();
            }

            var category = await cls_Category.CategoryDetails(id);
            return View("~/Views/Admin/Category/CategoryEdit.cshtml", category);

        }

        [HttpPost]
        public IActionResult CategoryEdit(Category category)
        {
            bool answer = Cls_Category.CategoryUpdate(category);
            if (answer == true)
            {
                TempData["Message"] = "Güncellendi";
                return RedirectToAction("~/Views/Admin/Category/CategoryEdit.cshtml");
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

            return View("~/Views/Admin/Category/CategoryDetails.cshtml", catergory);
        }

        // Delete category
        [HttpGet]
        public async Task<IActionResult> CategoryDelete(int? id)
        {
            if (id == null || context.Categories == null)
            {
                return NotFound();
            }

            var category = await context.Categories.FirstOrDefaultAsync(c => c.CategoryID == id);

            if (category == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Category/CategoryDelete.cshtml", category);
        }

        // Url'de ActionName yazıyor
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

    }
}