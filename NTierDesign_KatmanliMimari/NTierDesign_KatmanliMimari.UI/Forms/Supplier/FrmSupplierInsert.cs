using NTierDesign_KatmanliMimari.BusinessLayer;
using NTierDesign_KatmanliMimari.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierDesign_KatmanliMimari.UI.Forms.Supplier
{
    public partial class FrmSupplierInsert : Form
    {
        public FrmSupplierInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cls_Supplier cls_Supplier = new Cls_Supplier();
            cls_Supplier.CompanyName = txt_CompanyName.Text;
            cls_Supplier.ContactName = txt_ContactName.Text;
            bool result = cls_Supplier.Save();
            string message;
            message = Cls_CommonMessages.Common_Message_Method("Suppliers", result, "insert");
            MessageBox.Show(message);
            clear();
        }

        void clear()
        {
            txt_CompanyName.Text = txt_ContactName.Text = "";
        }
    }
}
