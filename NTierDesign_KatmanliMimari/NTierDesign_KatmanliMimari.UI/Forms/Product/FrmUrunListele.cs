using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void lst_productList_Click(object sender, EventArgs e)
        {
            listViewID = Convert.ToInt32(lst_productList.FocusedItem.Text);
        }
    }
}
