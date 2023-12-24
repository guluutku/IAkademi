using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View(mpm);
        }

        public PartialViewResult _PartialNewProducts(string pageno)
        {
            int pagenumber = Convert.ToInt32(pageno);
            mpm.NewProducts = cls_Product.ProductSelect("New", mainpageCount, "New", pagenumber); //yeni
            return PartialView(mpm);
        }

        public IActionResult SpecialProducts()
        {
            return View();
        }

        public IActionResult DiscountedProducts()
        {
            return View();
        }

        public IActionResult HighlightedProducts()
        {
            return View();
        }

        public IActionResult TopSelledProducts()
        {
            return View();
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