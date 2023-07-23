using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desr8_Random_Doğru_Sayiyi_Bulmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rastgele, sayac;

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_control.Enabled = true;

            // Class1 class1 = new Class1();
            // class1.static_olmayan_method(); // static method değil
            // Class1.static_method(); // static method çağırma

            Random random = new Random();

            rastgele = random.Next(1, 100); // static method değil
            sayac = 10;
            lbl_sayac.Text = sayac.ToString();
            lbl_durum.Text = "";
            txt_sayi.Text = "";

        }

        private void btn_control_Click(object sender, EventArgs e)
        {
            if (txt_sayi.Text == "")
            {
                lbl_durum.Text = "Sayı Giriniz";
            }
            else
            {
                int girilenSayi = Convert.ToInt32(txt_sayi.Text);
                if (girilenSayi < rastgele)
                {
                    lbl_durum.Text = "Düşük sayı girdiniz";
                    sayac--;
                }
                else if (girilenSayi > rastgele)
                {
                    lbl_durum.Text = "Yüksek sayı girdiniz";
                    sayac--;
                }
                else
                {
                    lbl_durum.Text = "Doğru sayı girdiniz";
                    btn_control.Enabled = false;
                }
            }
            lbl_sayac.Text = sayac.ToString();
            if (sayac <= 0)
            {
                lbl_durum.Text = "Kaybettiniz";
                btn_control.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_control.Enabled = false;
        }
    }
}
