using NTierDesign_KatmanliMimari.BusinessLayer;
using NTierDesign_KatmanliMimari.DataLayer;
using NTierDesign_KatmanliMimari.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierDesign_KatmanliMimari.UI.Forms.Product
{
    public partial class FrmUrunInsert : Form
    {
        public FrmUrunInsert()
        {
            InitializeComponent();
        }

        private void FrmUrunInsert_Load(object sender, EventArgs e)
        {
           FillCategoryCombobox();
           FillSupplierCombobox();
        }

        void FillCategoryCombobox()
        {
            Cls_Category cls_Category = new Cls_Category();
            List<vw_kategori_kismi_listesi> kategori_Kismi_Listesi = cls_Category.SelectByCategoryName();

            foreach (var item in kategori_Kismi_Listesi)
            {
                cmb_CategoryID.Items.Add(item.CategoryName);
            }
        }

        void FillSupplierCombobox()
        {
            Cls_Supplier cls_Supplier = new Cls_Supplier();
            SqlDataReader sdr = cls_Supplier.PartialSuppliersList();

            while (sdr.Read())
            {
                cmb_SupplierID.Items.Add(sdr["CompanyName"]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cls_Product cls_Product = new Cls_Product();

            cls_Product.ProductName = txt_ProductName.Text;
            cls_Product.UnitsInStock = Convert.ToInt32(txt_UnitsInStock.Text);
            cls_Product.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);
            // Get index from combo box
            cls_Product.CategoryID = cmb_CategoryID.SelectedIndex + 1;
            cls_Product.SupplierID = cmb_SupplierID.SelectedIndex + 1;

            bool result = cls_Product.Save();

            MessageBox.Show(Cls_CommonMessages.Common_Message_Method("Products", result, "insert"));

            clear();
        }

        void clear()
        {
            txt_ProductName.Clear();
            txt_UnitPrice.Clear();
            txt_UnitsInStock.Clear();
            cmb_CategoryID.SelectedIndex = -1;
            cmb_SupplierID.SelectedIndex = -1;
        }
    }
}
