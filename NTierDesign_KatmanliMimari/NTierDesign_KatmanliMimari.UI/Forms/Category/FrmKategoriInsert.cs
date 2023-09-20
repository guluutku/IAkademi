using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierDesign_KatmanliMimari.BusinessLayer;
using NTierDesign_KatmanliMimari.TypeLayer;

namespace NTierDesign_KatmanliMimari.UI.Forms.Category
{
    public partial class FrmKategoriInsert : Form
    {
        public FrmKategoriInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = Cls_Category.Save(txt_CategoryName.Text, txtDescription.Text);
            string message;
            message = Cls_CommonMessages.Common_Message_Method("Categories", result, "insert");
            MessageBox.Show(message);
            clear();
        }

        void clear()
        {
            txt_CategoryName.Text = txtDescription.Text = "";
        }
    }
}
