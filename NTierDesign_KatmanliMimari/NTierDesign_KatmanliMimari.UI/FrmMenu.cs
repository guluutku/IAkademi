using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierDesign_KatmanliMimari.UI;
using NTierDesign_KatmanliMimari.UI.Forms.Category;
using NTierDesign_KatmanliMimari.UI.Forms.Product;
using NTierDesign_KatmanliMimari.UI.Forms.Supplier;

namespace NTierDesign_KatmanliMimari.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void kATEGORİGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategoriInsert frmKategoriInsert = new FrmKategoriInsert();
            frmKategoriInsert.ShowDialog();
        }

        private void mARKAGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierInsert frmSupplierInsert = new FrmSupplierInsert();
            frmSupplierInsert.ShowDialog();
        }

        private void üRÜNGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunInsert frmUrunInsert = new FrmUrunInsert();
            frmUrunInsert.Show();
        }

        private void kATEGORİLİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategoriSelect frmKategoriSelect = new FrmKategoriSelect();
            frmKategoriSelect.ShowDialog();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunListele frm = new FrmUrunListele();
            frm.ShowDialog();
        }

        private void lİSTELEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupplierSelect frmSupplierSelect = new FrmSupplierSelect();
            frmSupplierSelect.ShowDialog();
        }
    }
}
