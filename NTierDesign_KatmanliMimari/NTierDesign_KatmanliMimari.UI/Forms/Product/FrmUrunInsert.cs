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
        }

        void FillCategoryCombobox()
        {
            Cls_Category cls_Category = new Cls_Category();
            SqlDataReader sdr = cls_Category.SelectByCategoryName();

            while (sdr.Read())
            {
                cmb_CategoryID.Items.Add(sdr["CategoryName"]);
            }
        }
    }
}
