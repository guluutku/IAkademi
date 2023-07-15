using Ders5_omboboc_ile_4islem.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_omboboc_ile_4islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cOMBOBOXİLE4İŞLEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_combobox_4_ıslem frm4 = new frm_combobox_4_ıslem();
            frm4.ShowDialog();
        }

        private void üRÜNGİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunGiris frmUrunGiris = new frmUrunGiris();
            frmUrunGiris.ShowDialog();
        }

        private void sABİTBİLGİLERGİRİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SabitBigiler frm_Sabit = new frm_SabitBigiler();
            frm_Sabit.ShowDialog();
        }
    }
}
