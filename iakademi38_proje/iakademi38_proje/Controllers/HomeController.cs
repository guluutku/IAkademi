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
        Cls_Order cls_Order = new Cls_Order();

        iakademi38Context context = new iakademi38Context();

        int mainPageCount = 0;

        public HomeController()
        {
            mainPageCount = context.Settings.FirstOrDefault(s => s.SettingID == 1)!.MainPageCount;
        }

        public IActionResult Index()
        {
            mpm.SliderProducts = cls_Product.ProductSelect("Slider", mainPageCount, "Ana", 0);
            mpm.NewProducts = cls_Product.ProductSelect("New", mainPageCount, "Ana", 0);
            mpm.SpecialProducts = cls_Product.ProductSelect("Special", mainPageCount, "Ana", 0);
            mpm.StarredProducts = cls_Product.ProductSelect("Starred", mainPageCount, "Ana", 0);
            mpm.FeaturedProducts = cls_Product.ProductSelect("Featured", mainPageCount, "Ana", 0); 
            mpm.NotableProducts = cls_Product.ProductSelect("Notable", mainPageCount, "Ana", 0); 

            mpm.DiscountedProducts = cls_Product.ProductSelect("Discounted", mainPageCount, "Ana", 0);
            mpm.HighlightedProducts= cls_Product.ProductSelect("Highlighted", mainPageCount, "Ana", 0);
            mpm.TopsellerProducts = cls_Product.ProductSelect("Topseller", mainPageCount, "Ana", 0);

            mpm.ProductOfDay = cls_Product.ProductDetails("ProductOfDay");

            return View(mpm);
        }

        public IActionResult Details(int id)
        {
            Cls_Product.Highligted_Increase(id);
            return View();
        }

        public IActionResult CartProcess(int id)
        {
            Cls_Product.Highligted_Increase(id);
            cls_Order.ProductID = 16;
            cls_Order.Quantity = 1;

            var cookieOptions = new CookieOptions();
            // read
            // 10=1&20=2&30=1
            var cookie = Request.Cookies["sepetim"]; // tarayıcıdan aldık, sepetim isminde çerezim var mı diye okuyor
            if(cookie == null)
            {
                // 10=1
                // 'sepetim' isminde cookie yok
                cookieOptions = new CookieOptions();
                // Otomatik cookie silme
                cookieOptions.Expires = DateTime.Now.AddDays(1); // 1 gün geçince çerez silinir
                cookieOptions.Path = "/";
                cls_Order.MyCart = "";
                cls_Order.AddToMyCart(id.ToString());
                Response.Cookies.Append("sepetim", cls_Order.MyCart, cookieOptions);
                // HttpContext.Session.SetString("Message", "Ürün Sepetinize Eklendi");
                TempData["Message"] = "Ürün Sepetinize Eklendi";
            }
            else
            {
                // 10=1&20=1
                // 'sepetim' isminde cookie var
                cls_Order.MyCart = cookie; // tarayıcıdaki sepet bilgilerini property'e gönder
                if(cls_Order.AddToMyCart(id.ToString()) == false)
                {
                    // aynı ürün sepette yok, eklenecek
                    cls_Order.AddToMyCart(id.ToString());
                    Response.Cookies.Append("sepetim", cls_Order.MyCart, cookieOptions);
                    cookieOptions.Expires = DateTime.Now.AddDays(1); // 1 gün geçince çerez silinir
                    TempData["Message"] = "Ürün Sepetinize Eklendi";
                }
                else
                {
                    // ürün önceden eklenmiş
                    TempData["Message"] = "Bu Ürün Zaten Sepetinizde Ekli";
                }

            }

            string url = Request.Headers["Referer"].ToString();
            return Redirect(url);
        }

        

    }
}
