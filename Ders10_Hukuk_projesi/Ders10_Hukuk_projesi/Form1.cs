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

namespace Ders10_Hukuk_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Method reference'dan geliyor.
            bool result = Common_Method.email_gonderim("alici@gmail.com", "gonderen@hotmail.com", "Mesaj");
            if (result)
            {
                MessageBox.Show("Gonderildi");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
