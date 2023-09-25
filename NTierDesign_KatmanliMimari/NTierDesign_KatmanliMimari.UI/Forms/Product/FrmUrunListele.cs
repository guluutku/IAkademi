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

namespace NTierDesign_KatmanliMimari.UI.Forms.Product
{
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }

        int listViewID = 0;

        Cls_Product cls_Product = new Cls_Product();

        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            FillProductList();
            FillSortCombobox();
        }

        void ReCreateList(SqlDataReader reader) 
        {
            lst_productList.Items.Clear();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader[0].ToString();
                listViewItem.SubItems.Add(reader[1].ToString());
                listViewItem.SubItems.Add(reader[2].ToString());
                listViewItem.SubItems.Add(reader[3].ToString());
                listViewItem.SubItems.Add(reader[4].ToString());
                listViewItem.SubItems.Add(reader[5].ToString());

                lst_productList.Items.Add(listViewItem);
            }
        }

        void FillProductList()
        {
            SqlDataReader sdr = cls_Product.SelectByProductName();
            ReCreateList(sdr);
        }

        void FillSortCombobox()
        {
            cmb_Sort.Items.Add("ID");
            cmb_Sort.Items.Add("AD");
            cmb_Sort.Items.Add("FİYAT");
            cmb_Sort.Items.Add("STOK");
            cmb_Sort.Items.Add("KATEGORİ");
            cmb_Sort.Items.Add("MARKA");
        }

        void SearchByProductName(string productName)
        {
            SqlDataReader sdr = cls_Product.SearchByProductName(productName);
            ReCreateList(sdr);
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByProductName(txt_search.Text);
        }

        private void cmb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SearchName = cmb_Sort.SelectedItem.ToString();
            SqlDataReader sdr = cls_Product.SortBy(SearchName, txt_search.Text);
            ReCreateList(sdr);
        }
    }
}
