using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_omboboc_ile_4islem.classes
{
    public class cls_Ortak
    {
        string telefonNo = "5366984526";
        public void telefon_no_kaydet(string yeniNo)
        {
            telefonNo = yeniNo;
        }
        public string telefon_no_getir()
        {
            return telefonNo;
        }
    }
}
