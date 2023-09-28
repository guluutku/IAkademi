using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders37_EntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NORTHWNDEntities context = new NORTHWNDEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCategoryCombobox();
        }

        void FillCategoryCombobox() 
        {
            // SELECT * FROM Categories
            // ado.net is faster
            List<Categories> sdr = context.Categories.ToList(); // entityframework

            foreach(var i in sdr)
            {
                cmb_category.Items.Add(i.CategoryName);
            }
        }
    }
}
