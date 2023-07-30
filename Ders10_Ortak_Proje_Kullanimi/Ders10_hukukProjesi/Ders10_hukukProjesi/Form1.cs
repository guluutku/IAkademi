using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders10_Ortak_API_Projem_DLL;

namespace Ders10_hukukProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          bool result =  Common_Metod.email_gonderim("mustafaselimgil@hotmail.com", "sedattefci1972@hotmail.com", "ders10 notları");

            if (result)
            {
                MessageBox.Show("Email gonderildi");
            }
            else
            {
                MessageBox.Show("HATA gönderilemedi");
            }
        }


    }
}
