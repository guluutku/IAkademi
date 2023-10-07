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

        public ActionResult Kategorili_Urunler()
        {
            // select CategoryID From Categories

            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}