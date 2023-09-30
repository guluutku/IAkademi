using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesign_KatmanliMimari.TypeLayer
{
    public class Cls_CommonMessages
    {

        public static string Common_Message_Method(string tabbleName, bool basarili, string CRUD)
        {
            string result;
            if (basarili)
            {
                if (CRUD == "insert")
                {
                    result = tabbleName + " tablosuna başarıyla eklendi";
                }
                else if (CRUD == "delete")
                {
                    result = tabbleName + " tablosundan başarıyla silinidi";
                }
                else if (CRUD == "update")
                {
                    result = tabbleName + " tablosu başarıyla güncellendi";
                }
                else
                {
                    result = tabbleName + ". Yanlış " + CRUD + " işlemi verildi";
                }
            }
            else
            {
                if (CRUD == "insert")
                {
                    result = tabbleName + " tablosuna ekleme başarısız";
                }
                else if (CRUD == "delete")
                {
                    result = tabbleName + " tablosundan silme başarısız";
                }
                else if (CRUD == "update")
                {
                    result = tabbleName + " tablosunu güncelleme başarısız";
                }
                else
                {
                    result = tabbleName + ". Yanlış " + CRUD + " işlemi verildi";
                }
            }
            return result.ToUpper();
        }

        public static string liste_secim_yapilmadi = "Listeden seçim yapılmadı";
    }
}
