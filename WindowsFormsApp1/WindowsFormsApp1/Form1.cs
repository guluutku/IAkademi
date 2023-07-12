using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Cls_Ogrenci cls_Ogrenci = new Cls_Ogrenci();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ogrenci = cls_Ogrenci.kaydet(txtBIsim.Text, txtBxSoyisim.Text, Convert.ToInt32(txtBYas.Text), txtBAdres.Text);
                if (ogrenci == "kaydedildi")
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Kaydetme Başarışız");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                bool ogrenci = cls_Ogrenci.guncelle(txtBIsim.Text, txtBxSoyisim.Text, Convert.ToInt32(txtBYas.Text), txtBAdres.Text, Convert.ToInt32(txt_ogrenci_id.Text));
                if (ogrenci)
                {
                    MessageBox.Show("Başarıyla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarışız");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
