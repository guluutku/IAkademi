using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10_muhasebeProjesi
{
    public partial class frmMaasInsert : Form
    {
        public frmMaasInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Maaş Verildi");
            }
            catch
            {
                MessageBox.Show("Maaş Verilemedi");
            }
        }
    }
}
