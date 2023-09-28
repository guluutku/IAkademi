using NTierDesign_KatmanliMimari.BusinessLayer;
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

        public FrmSupplierSelect()
        {
            InitializeComponent();
        }

        private void FrmSupplierSelect_Load(object sender, EventArgs e)
        {
            FillCategoryList();
        }

        void FillCategoryList()
        {
            SqlDataReader sdr = cls_Supplier.SelectBySupplierName();
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
    }
}
