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
    public partial class frmMuvekkilInsert : Form
    {
        public frmMuvekkilInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Kaydedildi");
            }
            catch
            {
                MessageBox.Show("Kaydedilemedi");
            }
        }
    }
}
