using Ders5_omboboc_ile_4islem.classes;
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
    public partial class frmUrunGiris : Form
    {
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        cls_Ortak ortak = new cls_Ortak();

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            lbl_telefonNo.Text = ortak.telefon_no_getir();
        }
    }
}
