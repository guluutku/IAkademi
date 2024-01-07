using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using static System.Net.WebRequestMethods;

namespace iakademi38_proje.Controllers
{
    public class HeaderController : Controller
    {

        MainPageModel mpm = new MainPageModel();
        Cls_Product cls_Product = new Cls_Product();
        Cls_Order cls_Order = new Cls_Order();

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

        // Sağ üst sayfadan sepet sayfama git ikonu tıklanınca ve aynı sayfada ürünü sil buton'u tıklanınca
        public IActionResult Cart()
        {
            List<Cls_Order> sepet; // property ile veri getirme
            string? scid = HttpContext.Request.Query["scid"]; // ürün silerken sil buton'u ile ProductID gönder

            if (HttpContext.Request.Query["scid"].ToString()! == "")
            {
                // sil butonu ile geldim
                cls_Order.MyCart = Request.Cookies["sepetim"]!;
                cls_Order.DeleteFromMyCart(scid);
                var cookieOptions = new CookieOptions();
                // Taratıcı silinmiş halini gönder
                Response.Cookies.Append("sepetim", cls_Order.MyCart, cookieOptions);
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                TempData["Message"] = "Ürün Sepetten Silindi";
                // sepet bilgilerini son haliyle cart.cshtml'ye gönder
                sepet = cls_Order.SelectMyCart();
                ViewBag.Sepetim = sepet;
                ViewBag.sepet_tablo_detay = sepet;
            }
            else
            {
                // Header'dan sepet buton'u ile geldim
                var cookie = Request.Cookies["sepetim"];
                if(cookie == null)
                {
                    cls_Order.MyCart = "";
                    sepet = cls_Order.SelectMyCart();
                    ViewBag.Sepetim = sepet;
                    ViewBag.sepet_tablo_detay = sepet;
                }
                else
                {
                    var cookieOptions = new CookieOptions();
                    cls_Order.MyCart = Request.Cookies["sepetim"];
                    sepet = cls_Order.SelectMyCart();
                    ViewBag.Sepetim = sepet;
                    ViewBag.sepet_tablo_detay = sepet;
                }
            }


            return View();
        }

    }
}
