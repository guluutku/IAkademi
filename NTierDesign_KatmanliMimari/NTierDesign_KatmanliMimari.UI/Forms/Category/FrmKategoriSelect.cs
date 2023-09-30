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

namespace NTierDesign_KatmanliMimari.UI.Forms.Category
{
    public partial class FrmKategoriSelect : Form
    {
        public FrmKategoriSelect()
        {
            InitializeComponent();
        }

        Cls_Category cls_Category = new Cls_Category();

        int listViewID;

        private void FrmKategoriSelect_Load(object sender, EventArgs e)
        {
            FillCategoryList();
        }

        void FillCategoryList()
        {
            List<vw_kategori_kismi_listesi> kategori_Kismi_Listesi = cls_Category.SelectByCategoryName();
            ReCreateList(kategori_Kismi_Listesi);
        }

        void ReCreateList(List<vw_kategori_kismi_listesi> kategori_Kismi_Listesi)
        {
            lst_categoryList.Items.Clear();

            foreach(var item in kategori_Kismi_Listesi)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.CategoryID.ToString();
                listViewItem.SubItems.Add(item.CategoryName);
                listViewItem.SubItems.Add(item.Description);

                lst_categoryList.Items.Add(listViewItem);
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByCategoryName(txt_search.Text);
        }

        void SearchByCategoryName(String categoryName)
        {
            SqlDataReader sqlDataReader = cls_Category.SearchByCategoryName(categoryName);
            //ReCreateList(sqlDataReader);
        }

        private void lst_categoryList_Click(object sender, EventArgs e)
        {
            listViewID = Convert.ToInt32(lst_categoryList.FocusedItem.SubItems[0].Text);
            txt_name.Text = lst_categoryList.FocusedItem.SubItems[1].Text;
            txt_description.Text = lst_categoryList.FocusedItem.SubItems[2].Text;
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
            cls_Category.CategoryName = txt_name.Text;
            cls_Category.CategoryDescription = txt_description.Text;
            cls_Category.CategoryID = listViewID;
            
            bool result = cls_Category.Update();
            if (result)
            {
                FillCategoryList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Categories", result, "update");
            MessageBox.Show(message);
            clear();
        }

        void clear()
        {
            txt_name.Text = txt_description.Text = "";
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
            cls_Category.CategoryID = listViewID;

            bool result = cls_Category.Delete();
            if (result)
            {
                FillCategoryList();
            }
            message = Cls_CommonMessages.Common_Message_Method("Categories", result, "delete");
            MessageBox.Show(message);
            clear();
        }
    }
}
