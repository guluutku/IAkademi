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
            FillCategoryCombobox();
            FillSupplierCombobox();
        }

        void clear()
        {
            txt_urunAdi.Text = txt_fiyat.Text = txt_stok.Text = "";
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
            SqlDataReader sdr;
            if (cmb_Sort.SelectedItem == null)
            {
                sdr = cls_Product.SearchByProductName(productName);
                ReCreateList(sdr);
                return;
            }
            SortProductsBy();
        }

        void SortProductsBy()
        {
            string SearchName = cmb_Sort.SelectedItem.ToString();
            SqlDataReader sdr = cls_Product.SortBy(SearchName, txt_search.Text);
            ReCreateList(sdr);
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByProductName(txt_search.Text);
        }

        private void cmb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortProductsBy();
        }

        private void lst_productList_Click(object sender, EventArgs e)
        {
            listViewID = Convert.ToInt32(lst_productList.FocusedItem.SubItems[0].Text);
            txt_urunAdi.Text = lst_productList.FocusedItem.SubItems[1].Text;
            txt_fiyat.Text = lst_productList.FocusedItem.SubItems[2].Text;
            txt_stok.Text = lst_productList.FocusedItem.SubItems[3].Text;
            cmb_kategoriAdi.Text = lst_productList.FocusedItem.SubItems[4].Text;
            cmb_markaAdi.Text = lst_productList.FocusedItem.SubItems[5].Text;
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

            cls_Product.ProductID = listViewID;
            cls_Product.ProductName = txt_urunAdi.Text;
            cls_Product.UnitPrice = Convert.ToDecimal(txt_fiyat.Text);
            cls_Product.UnitsInStock = Convert.ToInt32(txt_stok.Text);
            cls_Product.CategoryID = cmb_kategoriAdi.SelectedIndex + 1;
            cls_Product.SupplierID = cmb_markaAdi.SelectedIndex + 1;

            bool result = cls_Product.Update();
            if (result)
            {
                FillProductList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Products", result, "update");
            MessageBox.Show(message);
            clear();
        }

        void FillCategoryCombobox()
        {
            Cls_Category cls_Category = new Cls_Category();
            List<vw_kategori_kismi_listesi> kategori_Kismi_Listesi = cls_Category.SelectByCategoryName();

            foreach (var item in kategori_Kismi_Listesi)
            {
                cmb_kategoriAdi.Items.Add(item.CategoryName);
            }
        }

        void FillSupplierCombobox()
        {
            Cls_Supplier cls_Supplier = new Cls_Supplier();
            SqlDataReader sdr = cls_Supplier.PartialSuppliersList();

            while (sdr.Read())
            {
                cmb_markaAdi.Items.Add(sdr["CompanyName"]);
            }
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
            cls_Product.ProductID = listViewID;

            bool result = cls_Product.Delete();
            if (result)
            {
                FillProductList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Categories", result, "delete");
            MessageBox.Show(message);
            clear();
        }
    }
}
