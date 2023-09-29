using NTierDesign_KatmanliMimari.BusinessLayer;
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

namespace NTierDesign_KatmanliMimari.UI.Forms.Supplier
{
    public partial class FrmSupplierSelect : Form
    {

        Cls_Supplier cls_Supplier = new Cls_Supplier();
        int listViewID;

        public FrmSupplierSelect()
        {
            InitializeComponent();
        }

        private void FrmSupplierSelect_Load(object sender, EventArgs e)
        {
            FillSuppliersList();
        }

        void FillSuppliersList()
        {
            SqlDataReader sdr = cls_Supplier.PartialSuppliersList();
            ReCreateList(sdr);
        }

        void ReCreateList(SqlDataReader sdr)
        {
            lst_supplierList.Items.Clear();

            while (sdr.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sdr[0].ToString();
                listViewItem.SubItems.Add(sdr[1].ToString());
                listViewItem.SubItems.Add(sdr[2].ToString());

                lst_supplierList.Items.Add(listViewItem);
            }
        }

        void SearchByCompanyName(string seachName)
        {
            SqlDataReader sdr = cls_Supplier.SearchByCompanyName(seachName);
            ReCreateList(sdr);
        }

        private void lst_supplierList_Click(object sender, EventArgs e)
        {
            listViewID = Convert.ToInt32(lst_supplierList.FocusedItem.SubItems[0].Text);
            txt_companyName.Text = lst_supplierList.FocusedItem.SubItems[1].Text;
            txt_contactName.Text = lst_supplierList.FocusedItem.SubItems[2].Text;
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByCompanyName(txt_search.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string message;
            if (listViewID == 0)
            {
                message = Cls_CommonMessages.liste_secim_yapilmadi;
                MessageBox.Show(message);
                return;
            }
            cls_Supplier.CompanyName = txt_companyName.Text;
            cls_Supplier.ContactName = txt_contactName.Text;
            cls_Supplier.SupplierID = listViewID;

            bool result = cls_Supplier.Update();
            if (result)
            {
                FillSuppliersList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Supppliers", result, "update");
            MessageBox.Show(message);
            clear();
        }

        private void clear()
        {
            listViewID = 0;
            txt_companyName.Text = txt_contactName.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string message;
            if (listViewID == 0)
            {
                message = Cls_CommonMessages.liste_secim_yapilmadi;
                MessageBox.Show(message);
                return;
            }
            cls_Supplier.SupplierID = listViewID;

            bool result = cls_Supplier.Delete();
            if (result)
            {
                FillSuppliersList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Supppliers", result, "delete");
            MessageBox.Show(message);

            clear();
        }
    }
}
