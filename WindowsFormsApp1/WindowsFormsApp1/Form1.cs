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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Ogrenci cls_Ogrenci = new Cls_Ogrenci();
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
    }
}
