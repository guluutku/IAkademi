using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_ListView_Encapsulation.Classes
{
    public class Ogrenci
    {

        // encapsulation, büyük harfler zorunlu
        private string _isim { get; set; }
        public string isim
        {
            get { return _isim; }
            set
            {
                _isim = value.ToUpper();
            }
        }
        public string ogretmenIsmi { get; set; }
        public string bolum { get; set; }
        public string tcKimlik { get; set; }
        // encapsulation, 18 yaşından küükler eklenemez
        private int _yas { get; set; }
        public int yas
        {
            get { return _yas; }
            set
            {
                if (value >= 18)
                {
                    _yas = value;
                }
                else
                {
                    MessageBox.Show("18 yaşından büyük girilmeli");
                }
            }
        }

    }
}
