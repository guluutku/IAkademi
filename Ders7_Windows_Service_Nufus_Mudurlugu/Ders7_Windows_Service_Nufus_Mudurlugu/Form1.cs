using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Windows_Service_Nufus_Mudurlugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            TcKontrolServiceReference.KPSPublicSoapClient t = new TcKontrolServiceReference.KPSPublicSoapClient();
            bool result = t.TCKimlikNoDogrula(Convert.ToInt64(txt_tc_kimlik.Text), txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), Convert.ToInt32(txt_dogum_yili.Text));

            if(result)
            {
                // müvekkillerin kaydını veritabanına yazacağım
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Bilgiler yanlış grildi");
            }
        }
    }
}
