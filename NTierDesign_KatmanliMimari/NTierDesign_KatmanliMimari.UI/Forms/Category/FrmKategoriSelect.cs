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

namespace NTierDesign_KatmanliMimari.UI.Forms.Category
{
    public partial class FrmKategoriSelect : Form
    {
        public FrmKategoriSelect()
        {
            InitializeComponent();
        }

        private void FrmKategoriSelect_Load(object sender, EventArgs e)
        {
            FillCategoryCombobox();
        }

        void FillCategoryCombobox()
        {
            Cls_Category cls_Category = new Cls_Category();
            SqlDataReader sdr = cls_Category.SelectByCategoryName();

            while (sdr.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sdr[0].ToString();
                listViewItem.SubItems.Add(sdr[1].ToString());
                listViewItem.SubItems.Add(sdr[2].ToString());

                lst_categoryList.Items.Add(listViewItem);
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text = txt_search.Text;
        }
    }
}
