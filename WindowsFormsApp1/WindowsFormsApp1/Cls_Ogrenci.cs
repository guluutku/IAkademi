using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cls_Ogrenci
    {
        public Cls_Ogrenci() { }

        // Method:
        // public = erişim belirleyici
        // static var ya da yok
        // geriye dönüş tipi  
        // method'un ismi
        // varsa parantez içinde parametreler
        public string kaydet(string ad, string soyAd, int yas, string adres)
        {
            return "kaydedildi";
        }
        // method overwrite
        public string kaydet(bool ad, string soyAd, int yas, string adres)
        {
            return "kaydedildi";
        }
        // method overwrite
        public string kaydet(string soyAd, int yas, string adres, string ad)
        {
            return "kaydedildi";
        }

    }
}
