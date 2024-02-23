using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Newtonsoft.Json;

namespace iakademi38_proje.Controllers
{
    public class MainMenuController : Controller
    {

        Cls_Order cls_Order = new Cls_Order();
        Cls_Product cls_Product = new Cls_Product();

        iakademi38Context context = new iakademi38Context();

        public static string OrderGroupGUID = "";

        [HttpGet]
        public IActionResult Order()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                User? usr = Cls_User.SelectMemberInfo(HttpContext.Session.GetString("Email"));
                return View("~/Views/Header/Order.cshtml", usr);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Order(IFormCollection frm)
        {
            string txt_individual = Request.Form["txt_individual"];
            string txt_corporate = Request.Form["txt_corporate"];

            if (txt_individual != null)
            {
                //bireysel fatura
                //digital planet
                cls_Order.tckimlik_vergi_no = txt_individual;
                cls_Order.EfaturaCreate();
            }
            else
            {
                //kurumsal fatura
                cls_Order.tckimlik_vergi_no = txt_corporate;
                cls_Order.EfaturaCreate();
            }

            string kredikartno = Request.Form["kredikartno"];
            string kredikartay = frm["kredikartay"];
            string kredikartyil = frm["kredikartyil"];
            string kredikartcvs = frm["kredikartcvs"];

            return RedirectToAction("backref");

            //buradan sonraki kodlar , payu , iyzico
            //payu dan gelen örnek kodlar
            /*  AŞAGIDAKİ KODLAR GERÇEK HAYATTA AÇILALAK
             *  
                NameValueCollection data = new NameValueCollection();
                string url = "https://www.sedattefci.com/backref";
                data.Add("BACK_REF", url);
                data.Add("CC_CVV", kredikartcvs);
                data.Add("CC_NUMBER", kredikartno);
                data.Add("EXP_MONTH", kredikartay);
                data.Add("EXP_YEAR", "20" + kredikartyil);
 
                var deger = "";
 
                foreach (var item in data)
                {
                    var value = item as string;
                    var byteCount = Encoding.UTF8.GetByteCount(data.Get(value));
                    deger += byteCount + data.Get(value);
                }
 
                var signatureKey = "size verilen SECRET_KEY buraya yazılacak";
                var hash = HashWithSignature(deger, signatureKey);
                data.Add("ORDER_HASH", hash);
                var x = POSTFormPAYU("https://secure.payu.com.tr/order/....", data);

            //sanal kart
                if (x.Contains("<STATUS>SUCCESS</STATUS>") && x.Contains("<RETURN_CODE>3DS_ENROLLED</RETURN_CODE>"))
                {
                    //sanal kart (debit kart) ile alış veriş yaptı , bankadan onay aldı
                }
                else
                {
                    //gerçek kart ile alış veriş yaptı , bankadan onay aldı
                }
            */
        }

        public IActionResult backref()
        {
            ConfirmOrder();
            return RedirectToAction("ConfirmPage");
        }

        public IActionResult ConfirmOrder()
        {
            //sipariş tablosuna kaydet
            //sepetim cookie sinden sepeti temizleyecegiz
            //e-fatura olustur metodunu cagır
            var cookieOptions = new CookieOptions();
            var cookie = Request.Cookies["sepetim"];
            if (cookie != null)
            {
                cls_Order.MyCart = cookie;
                OrderGroupGUID = cls_Order.OrderCreate(HttpContext.Session.GetString("Email").ToString());

                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Delete("sepetim"); //tarayıcıdan sepeti sil
                                                    //    cls_User.Send_Sms(OrderGroupGUID);
                                                    //   cls_User.Send_Email(OrderGroupGUID);
            }
            return RedirectToAction("ConfirmPage");
        }

        public IActionResult ConfirmPage()
        {
            ViewBag.OrderGroupGUID = OrderGroupGUID;
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            string answer = Cls_User.MemberControl(user);

            if (answer == "error")
            {
                HttpContext.Session.SetString("Mesaj", "Email/Şifre yanlış girildi");
                TempData["Message"] = "Email/Şifre yanlış girildi";
                Console.WriteLine("Errorrr");
                return View();
            }
            else if (answer == "admin")
            {
                HttpContext.Session.SetString("Email", answer);
                HttpContext.Session.SetString("Admin", answer);

                Console.WriteLine("Admin");
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                HttpContext.Session.SetString("Email", answer);

                Console.WriteLine("Customer");
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (Cls_User.loginEmailControl(user) == false)
            {
                bool answer = Cls_User.AddUser(user);

                if (answer)
                {
                    TempData["Message"] = "Kaydedildi.";
                    return RedirectToAction("Login");
                }
                TempData["Message"] = "Hata.Tekrar deneyiniz.";
            }
            else
            {
                TempData["Message"] = "Bu Email Zaten mevcut.Başka Deneyiniz.";
            }
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult DetailedSearch()
        {
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Suppliers = context.Suppliers.ToList();
            return View();
        }

        public IActionResult CategoryPage(int id)
        {
            List<Product> products = cls_Product.ProductSelectWithCategoryID(id);
            return View(products);
        }
        
        public IActionResult SupplierPage(int id)
        {
            List<Product> products = cls_Product.ProductSelectWithSupplierID(id);
            return View(products);
        }

        public PartialViewResult gettingProducts(string id)
        {
            id = id.ToUpper(new System.Globalization.CultureInfo("tr-TR"));
            List<sp_arama> uList = Cls_Product.gettingSearchProducts(id);
            string json = JsonConvert.SerializeObject(uList);
            var response = JsonConvert.DeserializeObject<List<Search>>(json);

            return PartialView(response);
        }

    }
}