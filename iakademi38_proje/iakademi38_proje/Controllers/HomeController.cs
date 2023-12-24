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

        public IActionResult Index()
        {
            mpm.SliderProducts = cls_Product.ProductSelect("Slider");
            mpm.NewProducts = cls_Product.ProductSelect("New");
            mpm.SpecialProducts = cls_Product.ProductSelect("Special");
            mpm.StarredProducts = cls_Product.ProductSelect("Starred");
            mpm.FeaturedProducts = cls_Product.ProductSelect("Featured"); 
            mpm.NotableProducts = cls_Product.ProductSelect("Notable"); 

            mpm.DiscountedProducts = cls_Product.ProductSelect("Discounted");
            mpm.HighlightedProducts= cls_Product.ProductSelect("Highlighted");
            mpm.TopsellerProducts = cls_Product.ProductSelect("Topseller");

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

        public IActionResult NewProducts()
        {
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