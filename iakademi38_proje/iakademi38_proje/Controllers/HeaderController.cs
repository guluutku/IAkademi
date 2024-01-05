using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;

namespace iakademi38_proje.Controllers
{
    public class HeaderController : Controller
    {

        MainPageModel mpm = new MainPageModel();
        Cls_Product cls_Product = new Cls_Product();

        iakademi38Context context = new iakademi38Context();

        int mainpageCount = 0;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewProducts()
        {
            mpm.NewProducts = cls_Product.ProductSelect("New", mainpageCount, "New", 0);
            return View("~/Views/Product/NewProducts.cshtml", mpm);
        }


        public IActionResult SpecialProducts()
        {
            mpm.SpecialProducts = cls_Product.ProductSelect("Special", mainpageCount, "", 0);
            return View("~/Views/Product/SpecialProducts.cshtml", mpm);
        }

        public IActionResult DiscountedProducts()
        {
            mpm.DiscountedProducts = cls_Product.ProductSelect("Discounted", mainpageCount, "", 0);
            return View("~/Views/Product/DiscountedProducts.cshtml", mpm);
        }

        public IActionResult HighlightedProducts()
        {
            mpm.HighlightedProducts = cls_Product.ProductSelect("Highlighted", mainpageCount, "", 0);
            return View("~/Views/Product/HighlightedProducts.cshtml", mpm);
        }

        public IActionResult TopsellerProducts(int page = 1, int pageSize = 4)
        {
            // NuGet => install PagedList.Core
            PagedList<Product> model = new PagedList<Product>(context.Products.OrderByDescending(p => p.TopSeller), page, pageSize);

            return View("~/Views/Product/TopsellerProducts.cshtml", model);
        }

        public IActionResult MyOrders()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

    }
}