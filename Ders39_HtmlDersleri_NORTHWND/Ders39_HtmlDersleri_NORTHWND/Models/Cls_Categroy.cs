using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders39_HtmlDersleri_NORTHWND.Models
{
    public class Cls_Categroy
    {

        public static List<Categories> Select_Category_List()
        {
            using(NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities())
            {
                List<Categories> categoriesList = nORTHWNDEntities.Categories.ToList();

                return categoriesList;
            }
        }

    }
}