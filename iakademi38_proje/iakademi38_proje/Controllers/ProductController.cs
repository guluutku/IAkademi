using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XAct;

namespace iakademi38_proje.Controllers
{
    public class ProductController : Controller
    {

        Cls_Product cls_Product = new Cls_Product();
        Cls_Category cls_Category = new Cls_Category();
        Cls_Supplier cls_Supplier = new Cls_Supplier();
        Cls_Status cls_Status = new Cls_Status();
        iakademi38Context context = new iakademi38Context();
        MainPageModel mpm = new MainPageModel();

        int mainpageCount = 0;

        public ProductController()
        {
            mainpageCount = context.Settings.FirstOrDefault(s => s.SettingID == 1).MainPageCount;
        }

        // FOR ADMIN PAGES

        public async Task<IActionResult> ProductIndex()
        {
            List<Product> products = await cls_Product.ProductSelect();
            return View("~/Views/Admin/Product/ProductIndex.cshtml", products);
        }
        
        // Create Product
        [HttpGet]
        public async Task<IActionResult> ProductCreate()
        {
            List<Category> categories = await cls_Category.CategorySelect();
            ViewData["categoryList"] = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName, Value = c.CategoryID.ToString()
            });
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();
            ViewData["supplierList"] = suppliers.Select(s => new SelectListItem
            {
                Text = s.BrandName,
                Value = s.SupplierID.ToString()
            });

            List<Status> statuses = await cls_Status.StatusSelect();
            ViewData["statusList"] = statuses.Select(st => new SelectListItem
            {
                Text = st.StatusName,
                Value = st.StatusID.ToString()
            });

            return View("~/Views/Admin/Product/ProductCreate.cshtml");
        }
        
        [HttpPost]
        public IActionResult ProductCreate(Product Product)
        {
            bool answer = Cls_Product.ProductInsert(Product);
            if (answer == true)
            {
                TempData["Message"] = "Eklendi";
            }
            else
            {
                TempData["Message"] = "HATA";
            }
            return RedirectToAction(nameof(ProductCreate));
        }

        [HttpGet]
        public async Task<IActionResult> ProductEdit(int? id)
        {
            CategoryFill();
            SupplierFill();
            StatusFill();

            if (id == null || context.Suppliers == null)
            {
                return NotFound();
            }

            var product = await cls_Product.ProductDetails(id);
            return View("~/Views/Admin/Product/ProductEdit.cshtml", product);
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

        async void SupplierFill()
        {
            List<Supplier> suppliers = await cls_Supplier.SupplierSelect();
            ViewData["supplierList"] = suppliers.Select(s => new SelectListItem { Text = s.BrandName, Value = s.SupplierID.ToString() });
        }
        async void StatusFill()
        {
            List<Status> statuses = await cls_Status.StatusSelect();
            ViewData["statusList"] = statuses.Select(st => new SelectListItem { Text = st.StatusName, Value = st.StatusID.ToString() });
        }

        [HttpPost]
        public IActionResult ProductEdit(Product product)
        {
            //veritabanından kaydını getirdim
            Product prd = context.Products.FirstOrDefault(s => s.ProductID == product.ProductID);
            //formdan gelmeyen , bazı kolonları null yerine , eski bilgilerini bastım
            product.AddDate = prd.AddDate;
            product.HighLighted = prd.HighLighted;
            product.TopSeller = prd.TopSeller;

            if (product.PhotoPath == null)
            {
                string? PhotoPath = context.Products.FirstOrDefault(s => s.ProductID == product.ProductID).PhotoPath;
                product.PhotoPath = PhotoPath;
            }

            bool answer = Cls_Product.ProductUpdate(product);
            if (answer == true)
            {
                TempData["Message"] = "Güncellendi";
                return RedirectToAction("ProductIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(ProductEdit));
            }
        }
        //

        public async Task<IActionResult> ProductDetails(int? id)
        {
            var product = await cls_Product.ProductDetails(id);
            ViewBag.productname = product?.ProductName;
            return View("~/Views/Admin/Product/ProductDetails.cshtml", product);
        }
       
        [HttpGet]
        public async Task<IActionResult> ProductDelete(int? id)
        {
            if (id == null || context.Products == null)
            {
                return NotFound();
            }
            var product = await context.Products.FirstOrDefaultAsync(p => p.StatusID == id);

            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Product/ProductDelete.cshtml", product);
        }

        // Url'de ActionName yazıyor
        [HttpPost, ActionName("ProductDelete")]
        public IActionResult ProductDeleteConfirmed(int id)
        {
            bool answer = Cls_Product.ProductDelete(id);
            if (answer == true)
            {
                TempData["Message"] = "SİLİNDİ";
                return RedirectToAction("ProductIndex");
            }
            else
            {
                TempData["Message"] = "HATA";
                return RedirectToAction(nameof(ProductDelete));
            }

        }

        //////////////////////////
        // FOR USER PAGES

        public PartialViewResult _PartialNewProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.NewProducts = cls_Product.ProductSelect("New", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }

        public PartialViewResult _PartialSpecialProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.SpecialProducts = cls_Product.ProductSelect("Special", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }
        
        public PartialViewResult _PartialDiscountedProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.DiscountedProducts = cls_Product.ProductSelect("Discounted", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }

        public PartialViewResult _PartialHighlightedProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.HighlightedProducts = cls_Product.ProductSelect("Highlighted", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }

        public PartialViewResult _PartialTopSelledProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.TopSelledProducts = cls_Product.ProductSelect("TopSelled", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }

    }
}