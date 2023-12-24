using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class HomeController : Controller
    {

        MainPageModel mpm = new MainPageModel();
        Cls_Product cls_Product = new Cls_Product();

        iakademi38Context context = new iakademi38Context();

        int mainPageCount = 0;

        public HomeController()
        {
            mainPageCount = context.Settings.FirstOrDefault(s => s.SettingID == 1).MainPageCount;
        }

        public IActionResult Index()
        {
            mpm.SliderProducts = cls_Product.ProductSelect("Slider", mainPageCount, "", 0);
            mpm.NewProducts = cls_Product.ProductSelect("New", mainPageCount, "", 0);
            mpm.SpecialProducts = cls_Product.ProductSelect("Special", mainPageCount, "", 0);
            mpm.StarredProducts = cls_Product.ProductSelect("Starred", mainPageCount, "", 0);
            mpm.FeaturedProducts = cls_Product.ProductSelect("Featured", mainPageCount, "", 0); 
            mpm.NotableProducts = cls_Product.ProductSelect("Notable", mainPageCount, "", 0); 

            mpm.DiscountedProducts = cls_Product.ProductSelect("Discounted", mainPageCount, "", 0);
            mpm.HighlightedProducts= cls_Product.ProductSelect("Highlighted", mainPageCount, "", 0);
            mpm.TopsellerProducts = cls_Product.ProductSelect("Topseller", mainPageCount, "", 0);

            mpm.ProductOfDay = cls_Product.ProductDetails("ProductOfDay");

            return View(mpm);
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Cls_Product.Highligted_Increase(id);
            return View();
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

        public IActionResult CartProcess(int id)
        {
            Cls_Product.Highligted_Increase(id);
            string url = Request.Headers["Referer"].ToString();
            return Redirect(url);
        }
    }
}