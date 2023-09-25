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

        void FillProductList()
        {
            SqlDataReader sdr = cls_Product.SelectByProductName();
            lst_productList.Items.Clear();

            while (sdr.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sdr[0].ToString();
                listViewItem.SubItems.Add(sdr[1].ToString());
                listViewItem.SubItems.Add(sdr[2].ToString());
                listViewItem.SubItems.Add(sdr[3].ToString());
                listViewItem.SubItems.Add(sdr[4].ToString());
                listViewItem.SubItems.Add(sdr[5].ToString());

                lst_productList.Items.Add(listViewItem);
            }
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
            lst_productList.Items.Clear();

            while (sdr.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = sdr[0].ToString();
                listViewItem.SubItems.Add(sdr[1].ToString());
                listViewItem.SubItems.Add(sdr[2].ToString());
                listViewItem.SubItems.Add(sdr[3].ToString());
                listViewItem.SubItems.Add(sdr[4].ToString());
                listViewItem.SubItems.Add(sdr[5].ToString());

                lst_productList.Items.Add(listViewItem);
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByProductName(txt_search.Text);
        }

        private void cmb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SearchName = cmb_Sort.SelectedItem.ToString();
            SqlDataReader sdr = cls_Product.SortBy(SearchName);
            lst_productList.Items.Clear();

            while (sdr.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = sdr[0].ToString();
                listViewItem.SubItems.Add(sdr[1].ToString());
                listViewItem.SubItems.Add(sdr[2].ToString());
                listViewItem.SubItems.Add(sdr[3].ToString());
                listViewItem.SubItems.Add(sdr[4].ToString());
                listViewItem.SubItems.Add(sdr[5].ToString());

                lst_productList.Items.Add(listViewItem);
            }
        }
    }
}
