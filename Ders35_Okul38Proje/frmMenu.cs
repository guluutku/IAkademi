﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders35_Okul38Proje
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void öĞRENCİGİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frmOgrenciGiris = new frmOgrenciGiris();
            frmOgrenciGiris.Show();
        }
    }
}
