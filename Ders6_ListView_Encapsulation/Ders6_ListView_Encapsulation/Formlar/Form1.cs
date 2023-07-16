using Ders6_ListView_Encapsulation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_ListView_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                isim = txt_isim.Text,
                ogretmenIsmi = txt_ogretmen_ismi.Text,
                bolum = txt_bolum.Text,
                tcKimlik = txt_tc_kimlik.Text,
                yas = Convert.ToInt32(txt_yas.Text),
            };

            // alternatif yapılış
            // Ogrenci o = new Ogrenci();
            // o.isim = txt_isim.Text;
            // o.ogretmenIsmi = txt_ogretmen_ismi.Text;
            // o.bolum = txt_bolum.Text;
            // o.tcKimlik = txt_tc_kimlik.Text;
            // o.yas = Convert.ToInt32(txt_yas.Text);

            // property'deki verileri listViewItem'da göstereceğiz
            ListViewItem lv = new ListViewItem();
            lv.Text = ogrenci.isim;
            lv.SubItems.Add(ogrenci.ogretmenIsmi);
            lv.SubItems.Add(ogrenci.bolum);
            lv.SubItems.Add(ogrenci.tcKimlik);
            lv.SubItems.Add(ogrenci.yas.ToString());

            lst_ogrenci.Items.Add(lv);
        }
    }
}
