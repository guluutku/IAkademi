using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ders39_HtmlDersleri_NORTHWND.Models;

namespace Ders39_HtmlDersleri_NORTHWND.Controllers
{
    public class HomeController : Controller
    {
        
        NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();

        // GET: Home
        public ActionResult Index()
        {
            List<Categories> categoryList = Cls_Categroy.Select_Category_List();

            return View(categoryList);
        }

        public ActionResult KategoriUrunler(int id)
        {
            //ORM = VS ile, veritabanı arasındaki bağlantı

            // SELECT * FROM Produccts WHERE CategoryID = id (ado.net)

            // entityframework(.net framework), entityframeworkcore (.net core)
            List<Products> products = nORTHWNDEntities.Products.Where(p => p.CategoryID == id).ToList();

            return View(products);
        }

        public ActionResult UrunleriListele()
        {
            List<Products> products = nORTHWNDEntities.Products.ToList();

            return View(products);
        }

        public ActionResult Index2()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index3(Categories categories)
        {
            return View();
        }

    }
}