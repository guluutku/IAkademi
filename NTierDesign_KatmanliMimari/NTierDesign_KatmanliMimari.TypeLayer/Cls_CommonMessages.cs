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
                    result = tabbleName + " tablo başarıyla eklendi";
                }
                else if (CRUD == "delete")
                {
                    result = tabbleName + " tablo başarıyla silinidi";
                }
                else if (CRUD == "update")
                {
                    result = tabbleName + " tablo başarıyla güncellendi";
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
                    result = tabbleName + " tabloya ekleme başarısız";
                }
                else if (CRUD == "delete")
                {
                    result = tabbleName + " tabloyu silme başarısız";
                }
                else if (CRUD == "update")
                {
                    result = tabbleName + " tabloyu güncelleme başarısız";
                }
                else
                {
                    result = tabbleName + ". Yanlış " + CRUD + " işlemi verildi";
                }
            }
            return result;
        }

    }
}
